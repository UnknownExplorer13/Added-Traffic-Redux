namespace Added_Traffic_Redux_Settings.Forms
{
	partial class frmSettings
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Downtown", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Vinewood", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("South Los Santos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Port of South Los Santos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("East Los Santos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Vespucci", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Los Santos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Grand Senora Desert", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("San Chianski Mountain Range", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Blaine County", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Fort Zancudo", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpbxWaitTime = new System.Windows.Forms.GroupBox();
            this.lblMorning = new System.Windows.Forms.Label();
            this.nudMorning = new System.Windows.Forms.NumericUpDown();
            this.lblAfternoon = new System.Windows.Forms.Label();
            this.nudAfternoon = new System.Windows.Forms.NumericUpDown();
            this.lblEvening = new System.Windows.Forms.Label();
            this.nudEvening = new System.Windows.Forms.NumericUpDown();
            this.lblNight = new System.Windows.Forms.Label();
            this.nudNight = new System.Windows.Forms.NumericUpDown();
            this.lblMidnight = new System.Windows.Forms.Label();
            this.nudMidnight = new System.Windows.Forms.NumericUpDown();
            this.tlpTheThreeGroups = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.grpbxGeneral = new System.Windows.Forms.GroupBox();
            this.lblCruiseSpeed = new System.Windows.Forms.Label();
            this.nudCruiseSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpawnDistance = new System.Windows.Forms.Label();
            this.nudSpawnDistance = new System.Windows.Forms.NumericUpDown();
            this.lblMaxVeh = new System.Windows.Forms.Label();
            this.nudMaxVeh = new System.Windows.Forms.NumericUpDown();
            this.lblDrivingStyle = new System.Windows.Forms.Label();
            this.cmbDrivingStyle = new System.Windows.Forms.ComboBox();
            this.lblRoadType = new System.Windows.Forms.Label();
            this.cmbRoadType = new System.Windows.Forms.ComboBox();
            this.cbSpawnParkedVeh = new System.Windows.Forms.CheckBox();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.grpbxDebug = new System.Windows.Forms.GroupBox();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.cbBlip = new System.Windows.Forms.CheckBox();
            this.cbDebugText = new System.Windows.Forms.CheckBox();
            this.pnlVehicleUpgrade = new System.Windows.Forms.Panel();
            this.grpbxVehicleUpgrade = new System.Windows.Forms.GroupBox();
            this.cbVehicleUpgrade = new System.Windows.Forms.CheckBox();
            this.cbRdWheels = new System.Windows.Forms.CheckBox();
            this.cbRdColor = new System.Windows.Forms.CheckBox();
            this.cbNeon = new System.Windows.Forms.CheckBox();
            this.lblChance = new System.Windows.Forms.Label();
            this.nudUpgradeChance = new System.Windows.Forms.NumericUpDown();
            this.tlpTheTwoList = new System.Windows.Forms.TableLayoutPanel();
            this.grpbxModelSwap = new System.Windows.Forms.GroupBox();
            this.lvVehicleSwap = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOldVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNewVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsVehicleSwap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSwapNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSwapEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSwapDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSwapChance = new System.Windows.Forms.Label();
            this.nudSwapChance = new System.Windows.Forms.NumericUpDown();
            this.lblSwapDistance = new System.Windows.Forms.Label();
            this.nudSwapDistance = new System.Windows.Forms.NumericUpDown();
            this.btnAddSwap = new System.Windows.Forms.Button();
            this.btnEditSwap = new System.Windows.Forms.Button();
            this.btnDelSwap = new System.Windows.Forms.Button();
            this.grpbxModelList = new System.Windows.Forms.GroupBox();
            this.cmsVehicleList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiListNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopyTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVW = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSLS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPSLS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiELS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGSD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSCMR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiListDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnEditModel = new System.Windows.Forms.Button();
            this.btnDelModel = new System.Windows.Forms.Button();
            this.llblWeb = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvModelList = new Added_Traffic_Redux_Settings.ListViewX();
            this.chListNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chListModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbxWaitTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMidnight)).BeginInit();
            this.tlpTheThreeGroups.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.grpbxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVeh)).BeginInit();
            this.pnlDebug.SuspendLayout();
            this.grpbxDebug.SuspendLayout();
            this.pnlVehicleUpgrade.SuspendLayout();
            this.grpbxVehicleUpgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgradeChance)).BeginInit();
            this.tlpTheTwoList.SuspendLayout();
            this.grpbxModelSwap.SuspendLayout();
            this.cmsVehicleSwap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapDistance)).BeginInit();
            this.grpbxModelList.SuspendLayout();
            this.cmsVehicleList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxWaitTime
            // 
            this.grpbxWaitTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxWaitTime.Controls.Add(this.lblMorning);
            this.grpbxWaitTime.Controls.Add(this.nudMorning);
            this.grpbxWaitTime.Controls.Add(this.lblAfternoon);
            this.grpbxWaitTime.Controls.Add(this.nudAfternoon);
            this.grpbxWaitTime.Controls.Add(this.lblEvening);
            this.grpbxWaitTime.Controls.Add(this.nudEvening);
            this.grpbxWaitTime.Controls.Add(this.lblNight);
            this.grpbxWaitTime.Controls.Add(this.nudNight);
            this.grpbxWaitTime.Controls.Add(this.lblMidnight);
            this.grpbxWaitTime.Controls.Add(this.nudMidnight);
            this.grpbxWaitTime.Location = new System.Drawing.Point(12, 12);
            this.grpbxWaitTime.Name = "grpbxWaitTime";
            this.grpbxWaitTime.Size = new System.Drawing.Size(760, 53);
            this.grpbxWaitTime.TabIndex = 0;
            this.grpbxWaitTime.TabStop = false;
            this.grpbxWaitTime.Text = "Wait Time (seconds)";
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Location = new System.Drawing.Point(6, 24);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(53, 15);
            this.lblMorning.TabIndex = 1;
            this.lblMorning.Text = "Morning";
            // 
            // nudMorning
            // 
            this.nudMorning.Location = new System.Drawing.Point(65, 22);
            this.nudMorning.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMorning.Name = "nudMorning";
            this.nudMorning.Size = new System.Drawing.Size(65, 23);
            this.nudMorning.TabIndex = 1;
            // 
            // lblAfternoon
            // 
            this.lblAfternoon.AutoSize = true;
            this.lblAfternoon.Location = new System.Drawing.Point(136, 24);
            this.lblAfternoon.Name = "lblAfternoon";
            this.lblAfternoon.Size = new System.Drawing.Size(61, 15);
            this.lblAfternoon.TabIndex = 2;
            this.lblAfternoon.Text = "Afternoon";
            // 
            // nudAfternoon
            // 
            this.nudAfternoon.Location = new System.Drawing.Point(203, 22);
            this.nudAfternoon.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAfternoon.Name = "nudAfternoon";
            this.nudAfternoon.Size = new System.Drawing.Size(65, 23);
            this.nudAfternoon.TabIndex = 2;
            // 
            // lblEvening
            // 
            this.lblEvening.AutoSize = true;
            this.lblEvening.Location = new System.Drawing.Point(274, 24);
            this.lblEvening.Name = "lblEvening";
            this.lblEvening.Size = new System.Drawing.Size(49, 15);
            this.lblEvening.TabIndex = 3;
            this.lblEvening.Text = "Evening";
            // 
            // nudEvening
            // 
            this.nudEvening.Location = new System.Drawing.Point(329, 22);
            this.nudEvening.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEvening.Name = "nudEvening";
            this.nudEvening.Size = new System.Drawing.Size(65, 23);
            this.nudEvening.TabIndex = 3;
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Location = new System.Drawing.Point(400, 24);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(37, 15);
            this.lblNight.TabIndex = 4;
            this.lblNight.Text = "Night";
            // 
            // nudNight
            // 
            this.nudNight.Location = new System.Drawing.Point(443, 22);
            this.nudNight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNight.Name = "nudNight";
            this.nudNight.Size = new System.Drawing.Size(65, 23);
            this.nudNight.TabIndex = 4;
            // 
            // lblMidnight
            // 
            this.lblMidnight.AutoSize = true;
            this.lblMidnight.Location = new System.Drawing.Point(514, 24);
            this.lblMidnight.Name = "lblMidnight";
            this.lblMidnight.Size = new System.Drawing.Size(56, 15);
            this.lblMidnight.TabIndex = 5;
            this.lblMidnight.Text = "Midnight";
            // 
            // nudMidnight
            // 
            this.nudMidnight.Location = new System.Drawing.Point(576, 22);
            this.nudMidnight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMidnight.Name = "nudMidnight";
            this.nudMidnight.Size = new System.Drawing.Size(65, 23);
            this.nudMidnight.TabIndex = 5;
            // 
            // tlpTheThreeGroups
            // 
            this.tlpTheThreeGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTheThreeGroups.ColumnCount = 3;
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTheThreeGroups.Controls.Add(this.pnlGeneral, 0, 0);
            this.tlpTheThreeGroups.Controls.Add(this.pnlDebug, 1, 0);
            this.tlpTheThreeGroups.Controls.Add(this.pnlVehicleUpgrade, 2, 0);
            this.tlpTheThreeGroups.Location = new System.Drawing.Point(9, 71);
            this.tlpTheThreeGroups.Name = "tlpTheThreeGroups";
            this.tlpTheThreeGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tlpTheThreeGroups.RowCount = 1;
            this.tlpTheThreeGroups.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTheThreeGroups.Size = new System.Drawing.Size(766, 118);
            this.tlpTheThreeGroups.TabIndex = 6;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.grpbxGeneral);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(5, 5);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(452, 108);
            this.pnlGeneral.TabIndex = 7;
            // 
            // grpbxGeneral
            // 
            this.grpbxGeneral.Controls.Add(this.lblCruiseSpeed);
            this.grpbxGeneral.Controls.Add(this.nudCruiseSpeed);
            this.grpbxGeneral.Controls.Add(this.lblSpawnDistance);
            this.grpbxGeneral.Controls.Add(this.nudSpawnDistance);
            this.grpbxGeneral.Controls.Add(this.lblMaxVeh);
            this.grpbxGeneral.Controls.Add(this.nudMaxVeh);
            this.grpbxGeneral.Controls.Add(this.lblDrivingStyle);
            this.grpbxGeneral.Controls.Add(this.cmbDrivingStyle);
            this.grpbxGeneral.Controls.Add(this.lblRoadType);
            this.grpbxGeneral.Controls.Add(this.cmbRoadType);
            this.grpbxGeneral.Controls.Add(this.cbSpawnParkedVeh);
            this.grpbxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxGeneral.Location = new System.Drawing.Point(0, 0);
            this.grpbxGeneral.Name = "grpbxGeneral";
            this.grpbxGeneral.Size = new System.Drawing.Size(452, 108);
            this.grpbxGeneral.TabIndex = 8;
            this.grpbxGeneral.TabStop = false;
            this.grpbxGeneral.Text = "General";
            // 
            // lblCruiseSpeed
            // 
            this.lblCruiseSpeed.AutoSize = true;
            this.lblCruiseSpeed.Location = new System.Drawing.Point(6, 25);
            this.lblCruiseSpeed.Name = "lblCruiseSpeed";
            this.lblCruiseSpeed.Size = new System.Drawing.Size(75, 15);
            this.lblCruiseSpeed.TabIndex = 9;
            this.lblCruiseSpeed.Text = "Cruise Speed";
            // 
            // nudCruiseSpeed
            // 
            this.nudCruiseSpeed.DecimalPlaces = 2;
            this.nudCruiseSpeed.Location = new System.Drawing.Point(102, 22);
            this.nudCruiseSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCruiseSpeed.Name = "nudCruiseSpeed";
            this.nudCruiseSpeed.Size = new System.Drawing.Size(65, 23);
            this.nudCruiseSpeed.TabIndex = 9;
            // 
            // lblSpawnDistance
            // 
            this.lblSpawnDistance.AutoSize = true;
            this.lblSpawnDistance.Location = new System.Drawing.Point(6, 54);
            this.lblSpawnDistance.Name = "lblSpawnDistance";
            this.lblSpawnDistance.Size = new System.Drawing.Size(90, 15);
            this.lblSpawnDistance.TabIndex = 10;
            this.lblSpawnDistance.Text = "Spawn Distance";
            // 
            // nudSpawnDistance
            // 
            this.nudSpawnDistance.DecimalPlaces = 2;
            this.nudSpawnDistance.Location = new System.Drawing.Point(102, 51);
            this.nudSpawnDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSpawnDistance.Name = "nudSpawnDistance";
            this.nudSpawnDistance.Size = new System.Drawing.Size(65, 23);
            this.nudSpawnDistance.TabIndex = 10;
            // 
            // lblMaxVeh
            // 
            this.lblMaxVeh.AutoSize = true;
            this.lblMaxVeh.Location = new System.Drawing.Point(6, 82);
            this.lblMaxVeh.Name = "lblMaxVeh";
            this.lblMaxVeh.Size = new System.Drawing.Size(78, 15);
            this.lblMaxVeh.TabIndex = 11;
            this.lblMaxVeh.Text = "Max. Vehicles";
            // 
            // nudMaxVeh
            // 
            this.nudMaxVeh.Location = new System.Drawing.Point(102, 80);
            this.nudMaxVeh.Name = "nudMaxVeh";
            this.nudMaxVeh.Size = new System.Drawing.Size(65, 23);
            this.nudMaxVeh.TabIndex = 11;
            // 
            // lblDrivingStyle
            // 
            this.lblDrivingStyle.AutoSize = true;
            this.lblDrivingStyle.Location = new System.Drawing.Point(173, 25);
            this.lblDrivingStyle.Name = "lblDrivingStyle";
            this.lblDrivingStyle.Size = new System.Drawing.Size(73, 15);
            this.lblDrivingStyle.TabIndex = 12;
            this.lblDrivingStyle.Text = "Driving Style";
            // 
            // cmbDrivingStyle
            // 
            this.cmbDrivingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivingStyle.FormattingEnabled = true;
            this.cmbDrivingStyle.Items.AddRange(new object[] {
            "Normal",
            "IgnoreLights",
            "SometimesOvertakeTraffic",
            "Rushed",
            "AvoidTraffic",
            "AvoidTrafficExtremely"});
            this.cmbDrivingStyle.Location = new System.Drawing.Point(252, 22);
            this.cmbDrivingStyle.Name = "cmbDrivingStyle";
            this.cmbDrivingStyle.Size = new System.Drawing.Size(163, 23);
            this.cmbDrivingStyle.TabIndex = 12;
            // 
            // lblRoadType
            // 
            this.lblRoadType.AutoSize = true;
            this.lblRoadType.Location = new System.Drawing.Point(173, 54);
            this.lblRoadType.Name = "lblRoadType";
            this.lblRoadType.Size = new System.Drawing.Size(61, 15);
            this.lblRoadType.TabIndex = 13;
            this.lblRoadType.Text = "Road Type";
            // 
            // cmbRoadType
            // 
            this.cmbRoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoadType.FormattingEnabled = true;
            this.cmbRoadType.Items.AddRange(new object[] {
            "AsphaltRoad",
            "SimplePath",
            "UnderTheMap",
            "Water"});
            this.cmbRoadType.Location = new System.Drawing.Point(252, 51);
            this.cmbRoadType.Name = "cmbRoadType";
            this.cmbRoadType.Size = new System.Drawing.Size(163, 23);
            this.cmbRoadType.TabIndex = 13;
            // 
            // cbSpawnParkedVeh
            // 
            this.cbSpawnParkedVeh.AutoSize = true;
            this.cbSpawnParkedVeh.Location = new System.Drawing.Point(176, 81);
            this.cbSpawnParkedVeh.Name = "cbSpawnParkedVeh";
            this.cbSpawnParkedVeh.Size = new System.Drawing.Size(145, 19);
            this.cbSpawnParkedVeh.TabIndex = 14;
            this.cbSpawnParkedVeh.Text = "Spawn Parked Vehicles";
            this.cbSpawnParkedVeh.UseVisualStyleBackColor = true;
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.grpbxDebug);
            this.pnlDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDebug.Location = new System.Drawing.Point(461, 5);
            this.pnlDebug.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(110, 108);
            this.pnlDebug.TabIndex = 15;
            // 
            // grpbxDebug
            // 
            this.grpbxDebug.Controls.Add(this.cbNotify);
            this.grpbxDebug.Controls.Add(this.cbBlip);
            this.grpbxDebug.Controls.Add(this.cbDebugText);
            this.grpbxDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxDebug.Location = new System.Drawing.Point(0, 0);
            this.grpbxDebug.Name = "grpbxDebug";
            this.grpbxDebug.Size = new System.Drawing.Size(110, 108);
            this.grpbxDebug.TabIndex = 16;
            this.grpbxDebug.TabStop = false;
            this.grpbxDebug.Text = "Debug";
            // 
            // cbNotify
            // 
            this.cbNotify.AutoSize = true;
            this.cbNotify.Location = new System.Drawing.Point(6, 22);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(59, 19);
            this.cbNotify.TabIndex = 17;
            this.cbNotify.Text = "Notify";
            this.cbNotify.UseVisualStyleBackColor = true;
            // 
            // cbBlip
            // 
            this.cbBlip.AutoSize = true;
            this.cbBlip.Location = new System.Drawing.Point(6, 47);
            this.cbBlip.Name = "cbBlip";
            this.cbBlip.Size = new System.Drawing.Size(78, 19);
            this.cbBlip.TabIndex = 18;
            this.cbBlip.Text = "Show Blip";
            this.cbBlip.UseVisualStyleBackColor = true;
            // 
            // cbDebugText
            // 
            this.cbDebugText.AutoSize = true;
            this.cbDebugText.Location = new System.Drawing.Point(6, 72);
            this.cbDebugText.Name = "cbDebugText";
            this.cbDebugText.Size = new System.Drawing.Size(47, 19);
            this.cbDebugText.TabIndex = 19;
            this.cbDebugText.Text = "Text";
            this.cbDebugText.UseVisualStyleBackColor = true;
            // 
            // pnlVehicleUpgrade
            // 
            this.pnlVehicleUpgrade.Controls.Add(this.grpbxVehicleUpgrade);
            this.pnlVehicleUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicleUpgrade.Location = new System.Drawing.Point(575, 5);
            this.pnlVehicleUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVehicleUpgrade.Name = "pnlVehicleUpgrade";
            this.pnlVehicleUpgrade.Size = new System.Drawing.Size(186, 108);
            this.pnlVehicleUpgrade.TabIndex = 20;
            // 
            // grpbxVehicleUpgrade
            // 
            this.grpbxVehicleUpgrade.Controls.Add(this.cbVehicleUpgrade);
            this.grpbxVehicleUpgrade.Controls.Add(this.cbRdWheels);
            this.grpbxVehicleUpgrade.Controls.Add(this.cbRdColor);
            this.grpbxVehicleUpgrade.Controls.Add(this.cbNeon);
            this.grpbxVehicleUpgrade.Controls.Add(this.lblChance);
            this.grpbxVehicleUpgrade.Controls.Add(this.nudUpgradeChance);
            this.grpbxVehicleUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxVehicleUpgrade.Location = new System.Drawing.Point(0, 0);
            this.grpbxVehicleUpgrade.Name = "grpbxVehicleUpgrade";
            this.grpbxVehicleUpgrade.Size = new System.Drawing.Size(186, 108);
            this.grpbxVehicleUpgrade.TabIndex = 21;
            this.grpbxVehicleUpgrade.TabStop = false;
            this.grpbxVehicleUpgrade.Text = "Vehicle Upgrade";
            // 
            // cbVehicleUpgrade
            // 
            this.cbVehicleUpgrade.AutoSize = true;
            this.cbVehicleUpgrade.Location = new System.Drawing.Point(6, 22);
            this.cbVehicleUpgrade.Name = "cbVehicleUpgrade";
            this.cbVehicleUpgrade.Size = new System.Drawing.Size(61, 19);
            this.cbVehicleUpgrade.TabIndex = 22;
            this.cbVehicleUpgrade.Text = "Enable";
            this.cbVehicleUpgrade.UseVisualStyleBackColor = true;
            // 
            // cbRdWheels
            // 
            this.cbRdWheels.AutoSize = true;
            this.cbRdWheels.Location = new System.Drawing.Point(6, 47);
            this.cbRdWheels.Name = "cbRdWheels";
            this.cbRdWheels.Size = new System.Drawing.Size(112, 19);
            this.cbRdWheels.TabIndex = 23;
            this.cbRdWheels.Text = "Random Wheels";
            this.cbRdWheels.UseVisualStyleBackColor = true;
            // 
            // cbRdColor
            // 
            this.cbRdColor.AutoSize = true;
            this.cbRdColor.Location = new System.Drawing.Point(73, 22);
            this.cbRdColor.Name = "cbRdColor";
            this.cbRdColor.Size = new System.Drawing.Size(103, 19);
            this.cbRdColor.TabIndex = 24;
            this.cbRdColor.Text = "Random Color";
            this.cbRdColor.UseVisualStyleBackColor = true;
            // 
            // cbNeon
            // 
            this.cbNeon.AutoSize = true;
            this.cbNeon.Location = new System.Drawing.Point(124, 47);
            this.cbNeon.Name = "cbNeon";
            this.cbNeon.Size = new System.Drawing.Size(55, 19);
            this.cbNeon.TabIndex = 25;
            this.cbNeon.Text = "Neon";
            this.cbNeon.UseVisualStyleBackColor = true;
            // 
            // lblChance
            // 
            this.lblChance.AutoSize = true;
            this.lblChance.Location = new System.Drawing.Point(3, 74);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(68, 15);
            this.lblChance.TabIndex = 26;
            this.lblChance.Text = "Chance (%)";
            // 
            // nudUpgradeChance
            // 
            this.nudUpgradeChance.Location = new System.Drawing.Point(77, 72);
            this.nudUpgradeChance.Name = "nudUpgradeChance";
            this.nudUpgradeChance.Size = new System.Drawing.Size(65, 23);
            this.nudUpgradeChance.TabIndex = 26;
            // 
            // tlpTheTwoList
            // 
            this.tlpTheTwoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTheTwoList.ColumnCount = 2;
            this.tlpTheTwoList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpTheTwoList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTheTwoList.Controls.Add(this.grpbxModelSwap, 0, 0);
            this.tlpTheTwoList.Controls.Add(this.grpbxModelList, 1, 0);
            this.tlpTheTwoList.Location = new System.Drawing.Point(9, 192);
            this.tlpTheTwoList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTheTwoList.Name = "tlpTheTwoList";
            this.tlpTheTwoList.RowCount = 1;
            this.tlpTheTwoList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTheTwoList.Size = new System.Drawing.Size(766, 331);
            this.tlpTheTwoList.TabIndex = 27;
            // 
            // grpbxModelSwap
            // 
            this.grpbxModelSwap.Controls.Add(this.lvVehicleSwap);
            this.grpbxModelSwap.Controls.Add(this.lblSwapChance);
            this.grpbxModelSwap.Controls.Add(this.nudSwapChance);
            this.grpbxModelSwap.Controls.Add(this.lblSwapDistance);
            this.grpbxModelSwap.Controls.Add(this.nudSwapDistance);
            this.grpbxModelSwap.Controls.Add(this.btnAddSwap);
            this.grpbxModelSwap.Controls.Add(this.btnEditSwap);
            this.grpbxModelSwap.Controls.Add(this.btnDelSwap);
            this.grpbxModelSwap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxModelSwap.Location = new System.Drawing.Point(2, 2);
            this.grpbxModelSwap.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxModelSwap.Name = "grpbxModelSwap";
            this.grpbxModelSwap.Padding = new System.Windows.Forms.Padding(0);
            this.grpbxModelSwap.Size = new System.Drawing.Size(493, 327);
            this.grpbxModelSwap.TabIndex = 28;
            this.grpbxModelSwap.TabStop = false;
            this.grpbxModelSwap.Text = "Model Swap (If New Model is blank, it will take a random model from the Model Lis" +
    "t)";
            // 
            // lvVehicleSwap
            // 
            this.lvVehicleSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVehicleSwap.CheckBoxes = true;
            this.lvVehicleSwap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chOldVehicle,
            this.chNewVehicle});
            this.lvVehicleSwap.ContextMenuStrip = this.cmsVehicleSwap;
            this.lvVehicleSwap.FullRowSelect = true;
            this.lvVehicleSwap.HideSelection = false;
            this.lvVehicleSwap.Location = new System.Drawing.Point(3, 19);
            this.lvVehicleSwap.Name = "lvVehicleSwap";
            this.lvVehicleSwap.Size = new System.Drawing.Size(487, 276);
            this.lvVehicleSwap.TabIndex = 29;
            this.lvVehicleSwap.UseCompatibleStateImageBehavior = false;
            this.lvVehicleSwap.View = System.Windows.Forms.View.Details;
            this.lvVehicleSwap.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvVehicleSwap_ItemChecked);
            // 
            // chNo
            // 
            this.chNo.Text = "Enable";
            this.chNo.Width = 50;
            // 
            // chOldVehicle
            // 
            this.chOldVehicle.Text = "Old Model";
            this.chOldVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOldVehicle.Width = 208;
            // 
            // chNewVehicle
            // 
            this.chNewVehicle.Text = "New Model";
            this.chNewVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNewVehicle.Width = 208;
            // 
            // cmsVehicleSwap
            // 
            this.cmsVehicleSwap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSwapNew,
            this.tsmiSwapEdit,
            this.toolStripSeparator1,
            this.tsmiSwapDelete});
            this.cmsVehicleSwap.Name = "cmsVehicleSwap";
            this.cmsVehicleSwap.Size = new System.Drawing.Size(108, 76);
            // 
            // tsmiSwapNew
            // 
            this.tsmiSwapNew.Name = "tsmiSwapNew";
            this.tsmiSwapNew.Size = new System.Drawing.Size(107, 22);
            this.tsmiSwapNew.Text = "New";
            this.tsmiSwapNew.Click += new System.EventHandler(this.tsmiSwapNew_Click);
            // 
            // tsmiSwapEdit
            // 
            this.tsmiSwapEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiSwapEdit.Name = "tsmiSwapEdit";
            this.tsmiSwapEdit.Size = new System.Drawing.Size(107, 22);
            this.tsmiSwapEdit.Text = "Edit";
            this.tsmiSwapEdit.Click += new System.EventHandler(this.tsmiSwapEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // tsmiSwapDelete
            // 
            this.tsmiSwapDelete.Name = "tsmiSwapDelete";
            this.tsmiSwapDelete.Size = new System.Drawing.Size(107, 22);
            this.tsmiSwapDelete.Text = "Delete";
            this.tsmiSwapDelete.Click += new System.EventHandler(this.tsmiSwapDelete_Click);
            // 
            // lblSwapChance
            // 
            this.lblSwapChance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSwapChance.AutoSize = true;
            this.lblSwapChance.Location = new System.Drawing.Point(3, 303);
            this.lblSwapChance.Name = "lblSwapChance";
            this.lblSwapChance.Size = new System.Drawing.Size(99, 15);
            this.lblSwapChance.TabIndex = 30;
            this.lblSwapChance.Text = "Swap Chance (%)";
            // 
            // nudSwapChance
            // 
            this.nudSwapChance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSwapChance.Location = new System.Drawing.Point(108, 301);
            this.nudSwapChance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSwapChance.Name = "nudSwapChance";
            this.nudSwapChance.Size = new System.Drawing.Size(65, 23);
            this.nudSwapChance.TabIndex = 30;
            // 
            // lblSwapDistance
            // 
            this.lblSwapDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSwapDistance.AutoSize = true;
            this.lblSwapDistance.Location = new System.Drawing.Point(180, 303);
            this.lblSwapDistance.Name = "lblSwapDistance";
            this.lblSwapDistance.Size = new System.Drawing.Size(83, 15);
            this.lblSwapDistance.TabIndex = 31;
            this.lblSwapDistance.Text = "Swap Distance";
            // 
            // nudSwapDistance
            // 
            this.nudSwapDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSwapDistance.Location = new System.Drawing.Point(269, 301);
            this.nudSwapDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSwapDistance.Name = "nudSwapDistance";
            this.nudSwapDistance.Size = new System.Drawing.Size(65, 23);
            this.nudSwapDistance.TabIndex = 31;
            // 
            // btnAddSwap
            // 
            this.btnAddSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSwap.Location = new System.Drawing.Point(365, 301);
            this.btnAddSwap.Name = "btnAddSwap";
            this.btnAddSwap.Size = new System.Drawing.Size(38, 23);
            this.btnAddSwap.TabIndex = 32;
            this.btnAddSwap.Text = "Add";
            this.btnAddSwap.UseVisualStyleBackColor = true;
            this.btnAddSwap.Click += new System.EventHandler(this.tsmiSwapNew_Click);
            // 
            // btnEditSwap
            // 
            this.btnEditSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSwap.Location = new System.Drawing.Point(409, 301);
            this.btnEditSwap.Name = "btnEditSwap";
            this.btnEditSwap.Size = new System.Drawing.Size(38, 23);
            this.btnEditSwap.TabIndex = 33;
            this.btnEditSwap.Text = "Edit";
            this.btnEditSwap.UseVisualStyleBackColor = true;
            this.btnEditSwap.Click += new System.EventHandler(this.tsmiSwapEdit_Click);
            // 
            // btnDelSwap
            // 
            this.btnDelSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelSwap.Location = new System.Drawing.Point(453, 301);
            this.btnDelSwap.Name = "btnDelSwap";
            this.btnDelSwap.Size = new System.Drawing.Size(38, 23);
            this.btnDelSwap.TabIndex = 34;
            this.btnDelSwap.Text = "Del";
            this.btnDelSwap.UseVisualStyleBackColor = true;
            this.btnDelSwap.Click += new System.EventHandler(this.tsmiSwapDelete_Click);
            // 
            // grpbxModelList
            // 
            this.grpbxModelList.Controls.Add(this.lvModelList);
            this.grpbxModelList.Controls.Add(this.btnHelp);
            this.grpbxModelList.Controls.Add(this.btnAddModel);
            this.grpbxModelList.Controls.Add(this.btnEditModel);
            this.grpbxModelList.Controls.Add(this.btnDelModel);
            this.grpbxModelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxModelList.Location = new System.Drawing.Point(499, 2);
            this.grpbxModelList.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxModelList.Name = "grpbxModelList";
            this.grpbxModelList.Padding = new System.Windows.Forms.Padding(0);
            this.grpbxModelList.Size = new System.Drawing.Size(265, 327);
            this.grpbxModelList.TabIndex = 35;
            this.grpbxModelList.TabStop = false;
            this.grpbxModelList.Text = "Model List";
            // 
            // cmsVehicleList
            // 
            this.cmsVehicleList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListNew,
            this.tsmiListEdit,
            this.toolStripSeparator2,
            this.tsmiCopyTo,
            this.toolStripSeparator3,
            this.tsmiListDelete});
            this.cmsVehicleList.Name = "cmsVehicleList";
            this.cmsVehicleList.Size = new System.Drawing.Size(127, 104);
            // 
            // tsmiListNew
            // 
            this.tsmiListNew.Name = "tsmiListNew";
            this.tsmiListNew.Size = new System.Drawing.Size(126, 22);
            this.tsmiListNew.Text = "New";
            this.tsmiListNew.Click += new System.EventHandler(this.tsmiListNew_Click);
            // 
            // tsmiListEdit
            // 
            this.tsmiListEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiListEdit.Name = "tsmiListEdit";
            this.tsmiListEdit.Size = new System.Drawing.Size(126, 22);
            this.tsmiListEdit.Text = "Edit";
            this.tsmiListEdit.Click += new System.EventHandler(this.tsmiListEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmiCopyTo
            // 
            this.tsmiCopyTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDT,
            this.tsmiVW,
            this.tsmiSLS,
            this.tsmiPSLS,
            this.tsmiELS,
            this.tsmiVPC,
            this.tsmiLS,
            this.tsmiGSD,
            this.tsmiSCMR,
            this.tsmiBC,
            this.tsmiFZ});
            this.tsmiCopyTo.Name = "tsmiCopyTo";
            this.tsmiCopyTo.Size = new System.Drawing.Size(126, 22);
            this.tsmiCopyTo.Text = "Copy To...";
            // 
            // tsmiDT
            // 
            this.tsmiDT.Name = "tsmiDT";
            this.tsmiDT.Size = new System.Drawing.Size(232, 22);
            this.tsmiDT.Text = "Downtown";
            this.tsmiDT.Click += new System.EventHandler(this.tsmiDT_Click);
            // 
            // tsmiVW
            // 
            this.tsmiVW.Name = "tsmiVW";
            this.tsmiVW.Size = new System.Drawing.Size(232, 22);
            this.tsmiVW.Text = "Vinewood";
            this.tsmiVW.Click += new System.EventHandler(this.tsmiVW_Click);
            // 
            // tsmiSLS
            // 
            this.tsmiSLS.Name = "tsmiSLS";
            this.tsmiSLS.Size = new System.Drawing.Size(232, 22);
            this.tsmiSLS.Text = "South Los Santos";
            this.tsmiSLS.Click += new System.EventHandler(this.tsmiSLS_Click);
            // 
            // tsmiPSLS
            // 
            this.tsmiPSLS.Name = "tsmiPSLS";
            this.tsmiPSLS.Size = new System.Drawing.Size(232, 22);
            this.tsmiPSLS.Text = "Port of South Los Santos";
            this.tsmiPSLS.Click += new System.EventHandler(this.tsmiPSLS_Click);
            // 
            // tsmiELS
            // 
            this.tsmiELS.Name = "tsmiELS";
            this.tsmiELS.Size = new System.Drawing.Size(232, 22);
            this.tsmiELS.Text = "East Los Santos";
            this.tsmiELS.Click += new System.EventHandler(this.tsmiELS_Click);
            // 
            // tsmiVPC
            // 
            this.tsmiVPC.Name = "tsmiVPC";
            this.tsmiVPC.Size = new System.Drawing.Size(232, 22);
            this.tsmiVPC.Text = "Vespucci";
            this.tsmiVPC.Click += new System.EventHandler(this.tsmiVPC_Click);
            // 
            // tsmiLS
            // 
            this.tsmiLS.Name = "tsmiLS";
            this.tsmiLS.Size = new System.Drawing.Size(232, 22);
            this.tsmiLS.Text = "Los Santos";
            this.tsmiLS.Click += new System.EventHandler(this.tsmiLS_Click);
            // 
            // tsmiGSD
            // 
            this.tsmiGSD.Name = "tsmiGSD";
            this.tsmiGSD.Size = new System.Drawing.Size(232, 22);
            this.tsmiGSD.Text = "Grand Senora Desert";
            this.tsmiGSD.Click += new System.EventHandler(this.tsmiGSD_Click);
            // 
            // tsmiSCMR
            // 
            this.tsmiSCMR.Name = "tsmiSCMR";
            this.tsmiSCMR.Size = new System.Drawing.Size(232, 22);
            this.tsmiSCMR.Text = "San Chianski Mountain Range";
            this.tsmiSCMR.Click += new System.EventHandler(this.tsmiSCMR_Click);
            // 
            // tsmiBC
            // 
            this.tsmiBC.Name = "tsmiBC";
            this.tsmiBC.Size = new System.Drawing.Size(232, 22);
            this.tsmiBC.Text = "Blaine County";
            this.tsmiBC.Click += new System.EventHandler(this.tsmiBC_Click);
            // 
            // tsmiFZ
            // 
            this.tsmiFZ.Name = "tsmiFZ";
            this.tsmiFZ.Size = new System.Drawing.Size(232, 22);
            this.tsmiFZ.Text = "Fort Zancudo";
            this.tsmiFZ.Click += new System.EventHandler(this.tsmiFZ_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmiListDelete
            // 
            this.tsmiListDelete.Name = "tsmiListDelete";
            this.tsmiListDelete.Size = new System.Drawing.Size(126, 22);
            this.tsmiListDelete.Text = "Delete";
            this.tsmiListDelete.Click += new System.EventHandler(this.tsmiListDelete_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(2, 301);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModel.Location = new System.Drawing.Point(137, 301);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(38, 23);
            this.btnAddModel.TabIndex = 39;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.tsmiListNew_Click);
            // 
            // btnEditModel
            // 
            this.btnEditModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditModel.Location = new System.Drawing.Point(181, 301);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(38, 23);
            this.btnEditModel.TabIndex = 40;
            this.btnEditModel.Text = "Edit";
            this.btnEditModel.UseVisualStyleBackColor = true;
            this.btnEditModel.Click += new System.EventHandler(this.tsmiListEdit_Click);
            // 
            // btnDelModel
            // 
            this.btnDelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelModel.Location = new System.Drawing.Point(225, 301);
            this.btnDelModel.Name = "btnDelModel";
            this.btnDelModel.Size = new System.Drawing.Size(38, 23);
            this.btnDelModel.TabIndex = 41;
            this.btnDelModel.Text = "Del";
            this.btnDelModel.UseVisualStyleBackColor = true;
            this.btnDelModel.Click += new System.EventHandler(this.tsmiListDelete_Click);
            // 
            // llblWeb
            // 
            this.llblWeb.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llblWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblWeb.AutoSize = true;
            this.llblWeb.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.llblWeb.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llblWeb.Location = new System.Drawing.Point(12, 530);
            this.llblWeb.Name = "llblWeb";
            this.llblWeb.Size = new System.Drawing.Size(65, 15);
            this.llblWeb.TabIndex = 42;
            this.llblWeb.TabStop = true;
            this.llblWeb.Text = "My GitHub";
            this.llblWeb.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llblWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWeb_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(695, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvModelList
            // 
            this.lvModelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvModelList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chListNo,
            this.chListModel});
            this.lvModelList.ContextMenuStrip = this.cmsVehicleList;
            this.lvModelList.FullRowSelect = true;
            listViewGroup1.Header = "Downtown";
            listViewGroup1.Name = "Downtown";
            listViewGroup1.Tag = "";
            listViewGroup2.Header = "Vinewood";
            listViewGroup2.Name = "Vinewood";
            listViewGroup2.Tag = "";
            listViewGroup3.Header = "South Los Santos";
            listViewGroup3.Name = "South Los Santos";
            listViewGroup3.Tag = "";
            listViewGroup4.Header = "Port of South Los Santos";
            listViewGroup4.Name = "Port of South Los Santos";
            listViewGroup4.Tag = "";
            listViewGroup5.Header = "East Los Santos";
            listViewGroup5.Name = "East Los Santos";
            listViewGroup5.Tag = "";
            listViewGroup6.Header = "Vespucci";
            listViewGroup6.Name = "Vespucci";
            listViewGroup6.Tag = "";
            listViewGroup7.Header = "Los Santos";
            listViewGroup7.Name = "Los Santos";
            listViewGroup7.Tag = "";
            listViewGroup8.Header = "Grand Senora Desert";
            listViewGroup8.Name = "Grand Senora Desert";
            listViewGroup8.Tag = "";
            listViewGroup9.Header = "San Chianski Mountain Range";
            listViewGroup9.Name = "San Chianski Mountain Range";
            listViewGroup9.Tag = "";
            listViewGroup10.Header = "Blaine County";
            listViewGroup10.Name = "Blaine County";
            listViewGroup10.Tag = "";
            listViewGroup11.Header = "Fort Zancudo";
            listViewGroup11.Name = "Fort Zancudo";
            listViewGroup11.Tag = "";
            this.lvModelList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11});
            this.lvModelList.HideSelection = false;
            this.lvModelList.Location = new System.Drawing.Point(3, 19);
            this.lvModelList.Name = "lvModelList";
            this.lvModelList.Size = new System.Drawing.Size(259, 276);
            this.lvModelList.TabIndex = 37;
            this.lvModelList.UseCompatibleStateImageBehavior = false;
            this.lvModelList.View = System.Windows.Forms.View.Details;
            this.lvModelList.DoubleClick += new System.EventHandler(this.lvModelList_DoubleClick);
            // 
            // chListNo
            // 
            this.chListNo.Width = 0;
            // 
            // chListModel
            // 
            this.chListModel.Text = "Model";
            this.chListModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chListModel.Width = 238;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpbxWaitTime);
            this.Controls.Add(this.tlpTheThreeGroups);
            this.Controls.Add(this.tlpTheTwoList);
            this.Controls.Add(this.llblWeb);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Added Traffic Redux Settings GUI";
            this.grpbxWaitTime.ResumeLayout(false);
            this.grpbxWaitTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMidnight)).EndInit();
            this.tlpTheThreeGroups.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.grpbxGeneral.ResumeLayout(false);
            this.grpbxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVeh)).EndInit();
            this.pnlDebug.ResumeLayout(false);
            this.grpbxDebug.ResumeLayout(false);
            this.grpbxDebug.PerformLayout();
            this.pnlVehicleUpgrade.ResumeLayout(false);
            this.grpbxVehicleUpgrade.ResumeLayout(false);
            this.grpbxVehicleUpgrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgradeChance)).EndInit();
            this.tlpTheTwoList.ResumeLayout(false);
            this.grpbxModelSwap.ResumeLayout(false);
            this.grpbxModelSwap.PerformLayout();
            this.cmsVehicleSwap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapDistance)).EndInit();
            this.grpbxModelList.ResumeLayout(false);
            this.cmsVehicleList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox grpbxWaitTime;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.NumericUpDown nudMorning;
        private System.Windows.Forms.Label lblAfternoon;
        private System.Windows.Forms.NumericUpDown nudAfternoon;
        private System.Windows.Forms.Label lblEvening;
        private System.Windows.Forms.NumericUpDown nudEvening;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.NumericUpDown nudNight;
        private System.Windows.Forms.Label lblMidnight;
        private System.Windows.Forms.NumericUpDown nudMidnight;
        private System.Windows.Forms.TableLayoutPanel tlpTheThreeGroups;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.GroupBox grpbxGeneral;
        private System.Windows.Forms.Label lblCruiseSpeed;
        private System.Windows.Forms.NumericUpDown nudCruiseSpeed;
        private System.Windows.Forms.Label lblSpawnDistance;
        private System.Windows.Forms.NumericUpDown nudSpawnDistance;
        private System.Windows.Forms.Label lblMaxVeh;
        private System.Windows.Forms.NumericUpDown nudMaxVeh;
        private System.Windows.Forms.Label lblDrivingStyle;
        private System.Windows.Forms.ComboBox cmbDrivingStyle;
        private System.Windows.Forms.Label lblRoadType;
        private System.Windows.Forms.ComboBox cmbRoadType;
        private System.Windows.Forms.CheckBox cbSpawnParkedVeh;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.GroupBox grpbxDebug;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.CheckBox cbBlip;
        private System.Windows.Forms.CheckBox cbDebugText;
        private System.Windows.Forms.Panel pnlVehicleUpgrade;
        private System.Windows.Forms.GroupBox grpbxVehicleUpgrade;
        private System.Windows.Forms.CheckBox cbVehicleUpgrade;
        private System.Windows.Forms.CheckBox cbRdWheels;
        private System.Windows.Forms.CheckBox cbRdColor;
        private System.Windows.Forms.CheckBox cbNeon;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.NumericUpDown nudUpgradeChance;
        private System.Windows.Forms.TableLayoutPanel tlpTheTwoList;
        private System.Windows.Forms.GroupBox grpbxModelSwap;
        public System.Windows.Forms.ListView lvVehicleSwap;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chOldVehicle;
        private System.Windows.Forms.ColumnHeader chNewVehicle;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleSwap;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapDelete;
        private System.Windows.Forms.Label lblSwapChance;
        private System.Windows.Forms.NumericUpDown nudSwapChance;
        private System.Windows.Forms.Label lblSwapDistance;
        private System.Windows.Forms.NumericUpDown nudSwapDistance;
        private System.Windows.Forms.Button btnAddSwap;
        private System.Windows.Forms.Button btnEditSwap;
        private System.Windows.Forms.Button btnDelSwap;
        private System.Windows.Forms.GroupBox grpbxModelList;
        public ListViewX lvModelList;
        private System.Windows.Forms.ColumnHeader chListNo;
        private System.Windows.Forms.ColumnHeader chListModel;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleList;
        private System.Windows.Forms.ToolStripMenuItem tsmiListNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiListEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyTo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDT;
        private System.Windows.Forms.ToolStripMenuItem tsmiVW;
        private System.Windows.Forms.ToolStripMenuItem tsmiSLS;
        private System.Windows.Forms.ToolStripMenuItem tsmiPSLS;
        private System.Windows.Forms.ToolStripMenuItem tsmiELS;
        private System.Windows.Forms.ToolStripMenuItem tsmiVPC;
        private System.Windows.Forms.ToolStripMenuItem tsmiLS;
        private System.Windows.Forms.ToolStripMenuItem tsmiGSD;
        private System.Windows.Forms.ToolStripMenuItem tsmiSCMR;
        private System.Windows.Forms.ToolStripMenuItem tsmiBC;
        private System.Windows.Forms.ToolStripMenuItem tsmiFZ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiListDelete;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnEditModel;
        private System.Windows.Forms.Button btnDelModel;
        private System.Windows.Forms.LinkLabel llblWeb;
        private System.Windows.Forms.Button btnSave;
    }
}