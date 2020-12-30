﻿/*
==========================================================================
This file is part of Briefing Room for DCS World, a mission
generator for DCS World, by @akaAgar (https://github.com/akaAgar/briefing-room-for-dcs)

Briefing Room for DCS World is free software: you can redistribute it
and/or modify it under the terms of the GNU General Public License
as published by the Free Software Foundation, either version 3 of
the License, or (at your option) any later version.

Briefing Room for DCS World is distributed in the hope that it will
be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Briefing Room for DCS World. If not, see https://www.gnu.org/licenses/
==========================================================================
*/

using BriefingRoom4DCSWorld.DB;
using BriefingRoom4DCSWorld.Debug;
using BriefingRoom4DCSWorld.Mission;
using BriefingRoom4DCSWorld.Template;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BriefingRoom4DCSWorld.Generator
{
    /// <summary>
    /// Generates the <see cref="DCSMissionObjective"/> array.
    /// </summary>
    public class MissionGeneratorObjectives : IDisposable
    {
        /// <summary>
        /// Minimum objective distance variation.
        /// </summary>
        private const double OBJECTIVE_DISTANCE_VARIATION_MIN = 0.75;

        /// <summary>
        /// Maximum objective distance variation.
        /// </summary>
        private const double OBJECTIVE_DISTANCE_VARIATION_MAX = 1.25;

        /// <summary>
        /// List of already used objective names, to make sure each one is different.
        /// </summary>
        private readonly List<string> UsedObjectiveNames = new List<string>();

        /// <summary>
        /// Spawn point selector to use for objective generation.
        /// </summary>
        private readonly UnitMakerSpawnPointSelector SpawnPointSelector;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="spawnPointSelector">Spawn point selector to use for objective generation</param>
        public MissionGeneratorObjectives(UnitMakerSpawnPointSelector spawnPointSelector)
        {
            SpawnPointSelector = spawnPointSelector;
        }

        /// <summary>
        /// Generates the <see cref="DCSMissionObjective"/>.
        /// </summary>
        /// <param name="mission">The mission for which to generate objectives</param>
        /// <param name="template">Mission template to use</param>
        /// <param name="objectiveDB">Objective database entry</param>
        public void CreateObjectives(DCSMission mission, MissionTemplate template, DBEntryObjective objectiveDB)
        {
            // Set the array for the proper number of objective
            mission.Objectives = new DCSMissionObjective[template.ObjectiveCount];

            GenerateObjectivesData(mission, template, objectiveDB);
            GenerateObjectivesScript(mission);
        }

        /// <summary>
        /// Generates the data for the objectives.
        /// </summary>
        /// <param name="mission">The mission for which to generate objectives</param>
        /// <param name="template">Mission template to use</param>
        /// <param name="objectiveDB">Objective database entry</param>
        private void GenerateObjectivesData(DCSMission mission, MissionTemplate template, DBEntryObjective objectiveDB)
        {
            // Keep in mind the position of the last objective/player location.
            // Start with initial player location.
            Coordinates lastCoordinates = mission.InitialPosition;

            // Common family to use for all objectives if DBEntryObjectiveFlags.SingleTargetUnitFamily is set
            UnitFamily singleObjectiveUnitFamily = objectiveDB.GetRandomUnitFamily();

            for (int i = 0; i < template.ObjectiveCount; i++)
            {
                // Pick a random unique name, or a waypoint number if objectives shouldn't be named
                string objectiveName = PickUniqueObjectiveName();

                DebugLog.Instance.WriteLine($"Adding objective #{i + 1}, designated {objectiveName}", 1);

                // Compute a random distance from last position, in nautical miles
                double objectiveDistanceNM =
                    (i == 0) ?
                    Database.Instance.Common.DistanceFromTakeOffLocation[(int)template.ObjectiveDistance] :
                    Database.Instance.Common.DistanceBetweenObjectives[(int)template.ObjectiveDistance];

                MinMaxD distanceFromLast =
                    new MinMaxD(OBJECTIVE_DISTANCE_VARIATION_MIN, OBJECTIVE_DISTANCE_VARIATION_MAX) * objectiveDistanceNM;

                // Look for a valid spawn point
                DBEntryTheaterSpawnPoint? spawnPoint =
                    SpawnPointSelector.GetRandomSpawnPoint(
                        // If spawn point types are specified, use them. Else look for spawn points of any type
                        (objectiveDB.UnitGroup.SpawnPoints.Length > 0) ? objectiveDB.UnitGroup.SpawnPoints : null,
                        // Select spawn points at a proper distance from last location (previous objective or home airbase)
                        lastCoordinates, distanceFromLast,
                        // Make sure no objective is too close to the initial location
                        mission.InitialPosition, new MinMaxD(objectiveDistanceNM * OBJECTIVE_DISTANCE_VARIATION_MIN, 999999999),
                        GeneratorTools.GetEnemySpawnPointCoalition(template));

                // No spawn point found for the objective, abort mission creation.
                if (!spawnPoint.HasValue)
                    throw new Exception($"Failed to find a spawn point for objective {i + 1}");

                // Set the waypoint coordinates according the the inaccuracy defined in the objective database entry
                Coordinates waypointCoordinates =
                    spawnPoint.Value.Coordinates +
                    Coordinates.CreateRandom(objectiveDB.WaypointInaccuracy * Toolbox.NM_TO_METERS);

                // Select an objective family for the target if any or default to VehicleTransport.
                UnitFamily objectiveUnitFamily = singleObjectiveUnitFamily;

                if (!objectiveDB.Flags.HasFlag(DBEntryObjectiveFlags.SingleTargetUnitFamily))
                    objectiveUnitFamily = objectiveDB.GetRandomUnitFamily();

                // Set the mission objective
                mission.Objectives[i] = new DCSMissionObjective(
                    objectiveName, spawnPoint.Value.Coordinates, objectiveUnitFamily, waypointCoordinates);

                // Last position is now the position of this objective
                lastCoordinates = spawnPoint.Value.Coordinates;
            }

            // If the target is a static object, make sure the correct flag is enabled as it has an influence of some scripts
            mission.ObjectiveIsStatic = objectiveDB.UnitGroup.Category.HasValue && (objectiveDB.UnitGroup.Category.Value == UnitCategory.Static);

            // Make sure objectives are ordered by distance from the players' starting location
            mission.Objectives = mission.Objectives.OrderBy(x => mission.InitialPosition.GetDistanceFrom(x.WaypointCoordinates)).ToArray();
        }

        /// <summary>
        /// Generate Lua script for the objectives.
        /// </summary>
        /// <param name="mission">The mission for which to generate objectives</param>
        private void GenerateObjectivesScript(DCSMission mission)
        {
            mission.CoreLuaScript += "briefingRoom.mission.objectives = { }\r\n";

            for (int i = 0; i < mission.Objectives.Length; i++)
            {
                mission.CoreLuaScript +=
                    $"briefingRoom.mission.objectives[{i + 1}] = {{ " + 
                    $"[\"name\"] = \"{mission.Objectives[i].Name}\", " +
                    $"[\"coordinates\"] = {mission.Objectives[i].Coordinates.ToLuaTable()}, " +
                    $"[\"groupID\"] = 0, " +
                    $"[\"menuPath\"] = nil, " +
                    $"[\"status\"] = brMissionStatus.IN_PROGRESS, " +
                    $"[\"task\"] = \"Complete objective {mission.Objectives[i].Name}\", " +
                    $"[\"waypoint\"] = {mission.Objectives[i].WaypointCoordinates.ToLuaTable()}" +
                    " }\r\n";
            }
        }

        /// <summary>
        /// Returns an unused objective name.
        /// </summary>
        /// <returns>A objective name not used by any other objective</returns>
        private string PickUniqueObjectiveName()
        {
            string objectiveName;
            do
            {
                objectiveName = Toolbox.RandomFrom(Database.Instance.Common.WPNamesObjectives);
            } while (UsedObjectiveNames.Contains(objectiveName));
            UsedObjectiveNames.Add(objectiveName);

            return objectiveName;
        }

        /// <summary>
        /// <see cref="IDisposable"/> implementation.
        /// </summary>
        public void Dispose() { }
    }
}
