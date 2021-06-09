﻿namespace BriefingRoom4DCS.LegacyGUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.M_File = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.TabControlTemplate = new System.Windows.Forms.TabControl();
            this.TabPageSettings = new System.Windows.Forms.TabPage();
            this.TabPageObjectives = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.TabPageFlightGroups = new System.Windows.Forms.TabPage();
            this.FlightGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.DGVC_FGAircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC_FGCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC_FGPayload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC_FGCarrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.TabPageMissionFeatures = new System.Windows.Forms.TabPage();
            this.TabPageOptions = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeViewOptions = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TreeViewRealism = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TreeViewDCSMods = new System.Windows.Forms.TreeView();
            this.TabPageGeneratedMission = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStripMain.SuspendLayout();
            this.TabControlTemplate.SuspendLayout();
            this.TabPageObjectives.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.TabPageFlightGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightGroupsDataGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.TabPageOptions.SuspendLayout();
            this.TableLayoutPanelOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TabPageGeneratedMission.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_File});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(800, 24);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // M_File
            // 
            this.M_File.Name = "M_File";
            this.M_File.Size = new System.Drawing.Size(37, 20);
            this.M_File.Text = "&File";
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Location = new System.Drawing.Point(0, 428);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(800, 22);
            this.StatusStripMain.TabIndex = 1;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // TabControlTemplate
            // 
            this.TabControlTemplate.Controls.Add(this.TabPageSettings);
            this.TabControlTemplate.Controls.Add(this.TabPageObjectives);
            this.TabControlTemplate.Controls.Add(this.TabPageFlightGroups);
            this.TabControlTemplate.Controls.Add(this.TabPageMissionFeatures);
            this.TabControlTemplate.Controls.Add(this.TabPageOptions);
            this.TabControlTemplate.Controls.Add(this.TabPageGeneratedMission);
            this.TabControlTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlTemplate.Location = new System.Drawing.Point(0, 24);
            this.TabControlTemplate.Name = "TabControlTemplate";
            this.TabControlTemplate.SelectedIndex = 0;
            this.TabControlTemplate.Size = new System.Drawing.Size(800, 404);
            this.TabControlTemplate.TabIndex = 2;
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSettings.Size = new System.Drawing.Size(792, 378);
            this.TabPageSettings.TabIndex = 0;
            this.TabPageSettings.Text = "Settings";
            this.TabPageSettings.UseVisualStyleBackColor = true;
            // 
            // TabPageObjectives
            // 
            this.TabPageObjectives.Controls.Add(this.dataGridView1);
            this.TabPageObjectives.Controls.Add(this.toolStrip3);
            this.TabPageObjectives.Location = new System.Drawing.Point(4, 22);
            this.TabPageObjectives.Name = "TabPageObjectives";
            this.TabPageObjectives.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageObjectives.Size = new System.Drawing.Size(792, 378);
            this.TabPageObjectives.TabIndex = 1;
            this.TabPageObjectives.Text = "Objectives";
            this.TabPageObjectives.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton6.Text = "toolStripButton2";
            // 
            // TabPageFlightGroups
            // 
            this.TabPageFlightGroups.Controls.Add(this.FlightGroupsDataGridView);
            this.TabPageFlightGroups.Controls.Add(this.toolStrip2);
            this.TabPageFlightGroups.Location = new System.Drawing.Point(4, 22);
            this.TabPageFlightGroups.Name = "TabPageFlightGroups";
            this.TabPageFlightGroups.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageFlightGroups.Size = new System.Drawing.Size(792, 378);
            this.TabPageFlightGroups.TabIndex = 2;
            this.TabPageFlightGroups.Text = "Player flight groups";
            this.TabPageFlightGroups.UseVisualStyleBackColor = true;
            // 
            // FlightGroupsDataGridView
            // 
            this.FlightGroupsDataGridView.AllowUserToAddRows = false;
            this.FlightGroupsDataGridView.AllowUserToDeleteRows = false;
            this.FlightGroupsDataGridView.AllowUserToResizeColumns = false;
            this.FlightGroupsDataGridView.AllowUserToResizeRows = false;
            this.FlightGroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlightGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVC_FGAircraft,
            this.DGVC_FGCount,
            this.DGVC_FGPayload,
            this.DGVC_FGCarrier});
            this.FlightGroupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightGroupsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FlightGroupsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.FlightGroupsDataGridView.MultiSelect = false;
            this.FlightGroupsDataGridView.Name = "FlightGroupsDataGridView";
            this.FlightGroupsDataGridView.ReadOnly = true;
            this.FlightGroupsDataGridView.RowHeadersVisible = false;
            this.FlightGroupsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FlightGroupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FlightGroupsDataGridView.ShowCellErrors = false;
            this.FlightGroupsDataGridView.ShowCellToolTips = false;
            this.FlightGroupsDataGridView.ShowEditingIcon = false;
            this.FlightGroupsDataGridView.ShowRowErrors = false;
            this.FlightGroupsDataGridView.Size = new System.Drawing.Size(786, 347);
            this.FlightGroupsDataGridView.TabIndex = 2;
            this.FlightGroupsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FlightGroupsDataGridView_CellMouseClick);
            // 
            // DGVC_FGAircraft
            // 
            this.DGVC_FGAircraft.HeaderText = "Aircraft";
            this.DGVC_FGAircraft.Name = "DGVC_FGAircraft";
            this.DGVC_FGAircraft.ReadOnly = true;
            this.DGVC_FGAircraft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DGVC_FGCount
            // 
            this.DGVC_FGCount.HeaderText = "Count";
            this.DGVC_FGCount.Name = "DGVC_FGCount";
            this.DGVC_FGCount.ReadOnly = true;
            this.DGVC_FGCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DGVC_FGPayload
            // 
            this.DGVC_FGPayload.HeaderText = "Payload";
            this.DGVC_FGPayload.Name = "DGVC_FGPayload";
            this.DGVC_FGPayload.ReadOnly = true;
            this.DGVC_FGPayload.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DGVC_FGCarrier
            // 
            this.DGVC_FGCarrier.HeaderText = "Carrier";
            this.DGVC_FGCarrier.Name = "DGVC_FGCarrier";
            this.DGVC_FGCarrier.ReadOnly = true;
            this.DGVC_FGCarrier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton3.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton4.Text = "toolStripButton2";
            // 
            // TabPageMissionFeatures
            // 
            this.TabPageMissionFeatures.Location = new System.Drawing.Point(4, 22);
            this.TabPageMissionFeatures.Name = "TabPageMissionFeatures";
            this.TabPageMissionFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageMissionFeatures.Size = new System.Drawing.Size(792, 378);
            this.TabPageMissionFeatures.TabIndex = 5;
            this.TabPageMissionFeatures.Text = "Mission features";
            this.TabPageMissionFeatures.UseVisualStyleBackColor = true;
            // 
            // TabPageOptions
            // 
            this.TabPageOptions.Controls.Add(this.TableLayoutPanelOptions);
            this.TabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.TabPageOptions.Name = "TabPageOptions";
            this.TabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOptions.Size = new System.Drawing.Size(792, 378);
            this.TabPageOptions.TabIndex = 3;
            this.TabPageOptions.Text = "Options";
            this.TabPageOptions.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelOptions
            // 
            this.TableLayoutPanelOptions.ColumnCount = 3;
            this.TableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.TableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanelOptions.Controls.Add(this.groupBox1, 0, 0);
            this.TableLayoutPanelOptions.Controls.Add(this.groupBox2, 1, 0);
            this.TableLayoutPanelOptions.Controls.Add(this.groupBox3, 2, 0);
            this.TableLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelOptions.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelOptions.Name = "TableLayoutPanelOptions";
            this.TableLayoutPanelOptions.RowCount = 1;
            this.TableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.TableLayoutPanelOptions.Size = new System.Drawing.Size(786, 372);
            this.TableLayoutPanelOptions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TreeViewOptions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TreeViewOptions
            // 
            this.TreeViewOptions.CheckBoxes = true;
            this.TreeViewOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewOptions.Location = new System.Drawing.Point(3, 16);
            this.TreeViewOptions.Name = "TreeViewOptions";
            this.TreeViewOptions.ShowLines = false;
            this.TreeViewOptions.ShowPlusMinus = false;
            this.TreeViewOptions.ShowRootLines = false;
            this.TreeViewOptions.Size = new System.Drawing.Size(247, 347);
            this.TreeViewOptions.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TreeViewRealism);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(262, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // TreeViewRealism
            // 
            this.TreeViewRealism.CheckBoxes = true;
            this.TreeViewRealism.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewRealism.Location = new System.Drawing.Point(3, 16);
            this.TreeViewRealism.Name = "TreeViewRealism";
            this.TreeViewRealism.ShowLines = false;
            this.TreeViewRealism.ShowPlusMinus = false;
            this.TreeViewRealism.ShowRootLines = false;
            this.TreeViewRealism.Size = new System.Drawing.Size(255, 347);
            this.TreeViewRealism.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TreeViewDCSMods);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(529, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // TreeViewDCSMods
            // 
            this.TreeViewDCSMods.CheckBoxes = true;
            this.TreeViewDCSMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewDCSMods.Location = new System.Drawing.Point(3, 16);
            this.TreeViewDCSMods.Name = "TreeViewDCSMods";
            this.TreeViewDCSMods.ShowLines = false;
            this.TreeViewDCSMods.ShowPlusMinus = false;
            this.TreeViewDCSMods.ShowRootLines = false;
            this.TreeViewDCSMods.Size = new System.Drawing.Size(248, 347);
            this.TreeViewDCSMods.TabIndex = 1;
            // 
            // TabPageGeneratedMission
            // 
            this.TabPageGeneratedMission.Controls.Add(this.toolStrip1);
            this.TabPageGeneratedMission.Location = new System.Drawing.Point(4, 22);
            this.TabPageGeneratedMission.Name = "TabPageGeneratedMission";
            this.TabPageGeneratedMission.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGeneratedMission.Size = new System.Drawing.Size(792, 378);
            this.TabPageGeneratedMission.TabIndex = 4;
            this.TabPageGeneratedMission.Text = "Generated mission";
            this.TabPageGeneratedMission.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Name = "ContextMenuStripMain";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(786, 347);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Aircraft";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Count";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Payload";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Carrier";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlTemplate);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.TabControlTemplate.ResumeLayout(false);
            this.TabPageObjectives.ResumeLayout(false);
            this.TabPageObjectives.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.TabPageFlightGroups.ResumeLayout(false);
            this.TabPageFlightGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightGroupsDataGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.TabPageOptions.ResumeLayout(false);
            this.TableLayoutPanelOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.TabPageGeneratedMission.ResumeLayout(false);
            this.TabPageGeneratedMission.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.TabControl TabControlTemplate;
        private System.Windows.Forms.TabPage TabPageSettings;
        private System.Windows.Forms.TabPage TabPageObjectives;
        private System.Windows.Forms.TabPage TabPageFlightGroups;
        private System.Windows.Forms.TabPage TabPageMissionFeatures;
        private System.Windows.Forms.TabPage TabPageOptions;
        private System.Windows.Forms.TabPage TabPageGeneratedMission;
        private System.Windows.Forms.ToolStripMenuItem M_File;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView TreeViewOptions;
        private System.Windows.Forms.TreeView TreeViewRealism;
        private System.Windows.Forms.TreeView TreeViewDCSMods;
        private System.Windows.Forms.DataGridView FlightGroupsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC_FGAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC_FGCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC_FGPayload;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC_FGCarrier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}