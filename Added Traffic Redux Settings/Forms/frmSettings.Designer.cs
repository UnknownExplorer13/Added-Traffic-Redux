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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRoadType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDrivingStyle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSpawnParkedVeh = new System.Windows.Forms.CheckBox();
            this.nudMaxVeh = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudSpawnDistance = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCruiseSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDebugText = new System.Windows.Forms.CheckBox();
            this.cbBlip = new System.Windows.Forms.CheckBox();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpTheThreeGroups = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbNeon = new System.Windows.Forms.CheckBox();
            this.cbRdWheels = new System.Windows.Forms.CheckBox();
            this.nudUpgradeChance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRdColor = new System.Windows.Forms.CheckBox();
            this.cbVehicleUpgrade = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMidnight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudEvening = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAfternoon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMorning = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpTheTwoList = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudSwapChance = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudSwapDistance = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelSwap = new System.Windows.Forms.Button();
            this.btnEditSwap = new System.Windows.Forms.Button();
            this.btnAddSwap = new System.Windows.Forms.Button();
            lvVehicleSwap = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOldVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNewVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsVehicleSwap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSwapNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSwapEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSwapDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDelModel = new System.Windows.Forms.Button();
            this.btnEditModel = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            lvModelList = new Added_Traffic_Redux_Settings.ListViewX();
            this.chListNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chListModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnSave = new System.Windows.Forms.Button();
            this.llblWeb = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpTheThreeGroups.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgradeChance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMidnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorning)).BeginInit();
            this.tlpTheTwoList.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapDistance)).BeginInit();
            this.cmsVehicleSwap.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.cmsVehicleList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRoadType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbDrivingStyle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSpawnParkedVeh);
            this.groupBox1.Controls.Add(this.nudMaxVeh);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nudSpawnDistance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudCruiseSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
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
            this.cmbRoadType.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Road Type";
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
            this.cmbDrivingStyle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Driving Style";
            // 
            // cbSpawnParkedVeh
            // 
            this.cbSpawnParkedVeh.AutoSize = true;
            this.cbSpawnParkedVeh.Location = new System.Drawing.Point(173, 81);
            this.cbSpawnParkedVeh.Name = "cbSpawnParkedVeh";
            this.cbSpawnParkedVeh.Size = new System.Drawing.Size(145, 19);
            this.cbSpawnParkedVeh.TabIndex = 6;
            this.cbSpawnParkedVeh.Text = "Spawn Parked Vehicles";
            this.cbSpawnParkedVeh.UseVisualStyleBackColor = true;
            // 
            // nudMaxVeh
            // 
            this.nudMaxVeh.Location = new System.Drawing.Point(102, 80);
            this.nudMaxVeh.Name = "nudMaxVeh";
            this.nudMaxVeh.Size = new System.Drawing.Size(65, 23);
            this.nudMaxVeh.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Max. Vehicles";
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
            this.nudSpawnDistance.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Spawn Distance";
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
            this.nudCruiseSpeed.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cruise Speed";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDebugText);
            this.groupBox5.Controls.Add(this.cbBlip);
            this.groupBox5.Controls.Add(this.cbNotify);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 108);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // cbDebugText
            // 
            this.cbDebugText.AutoSize = true;
            this.cbDebugText.Location = new System.Drawing.Point(6, 72);
            this.cbDebugText.Name = "cbDebugText";
            this.cbDebugText.Size = new System.Drawing.Size(47, 19);
            this.cbDebugText.TabIndex = 3;
            this.cbDebugText.Text = "Text";
            this.cbDebugText.UseVisualStyleBackColor = true;
            // 
            // cbBlip
            // 
            this.cbBlip.AutoSize = true;
            this.cbBlip.Location = new System.Drawing.Point(6, 47);
            this.cbBlip.Name = "cbBlip";
            this.cbBlip.Size = new System.Drawing.Size(78, 19);
            this.cbBlip.TabIndex = 2;
            this.cbBlip.Text = "Show Blip";
            this.cbBlip.UseVisualStyleBackColor = true;
            // 
            // cbNotify
            // 
            this.cbNotify.AutoSize = true;
            this.cbNotify.Location = new System.Drawing.Point(6, 22);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(59, 19);
            this.cbNotify.TabIndex = 1;
            this.cbNotify.Text = "Notify";
            this.cbNotify.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 108);
            this.panel1.TabIndex = 5;
            // 
            // tlpTheThreeGroups
            // 
            this.tlpTheThreeGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTheThreeGroups.ColumnCount = 3;
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTheThreeGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTheThreeGroups.Controls.Add(this.panel1, 0, 0);
            this.tlpTheThreeGroups.Controls.Add(this.panel2, 1, 0);
            this.tlpTheThreeGroups.Controls.Add(this.panel3, 2, 0);
            this.tlpTheThreeGroups.Location = new System.Drawing.Point(9, 71);
            this.tlpTheThreeGroups.Name = "tlpTheThreeGroups";
            this.tlpTheThreeGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tlpTheThreeGroups.RowCount = 1;
            this.tlpTheThreeGroups.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTheThreeGroups.Size = new System.Drawing.Size(766, 118);
            this.tlpTheThreeGroups.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(461, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 108);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(575, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 108);
            this.panel3.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbNeon);
            this.groupBox4.Controls.Add(this.cbRdWheels);
            this.groupBox4.Controls.Add(this.nudUpgradeChance);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbRdColor);
            this.groupBox4.Controls.Add(this.cbVehicleUpgrade);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 108);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle Upgrade";
            // 
            // cbNeon
            // 
            this.cbNeon.AutoSize = true;
            this.cbNeon.Location = new System.Drawing.Point(124, 47);
            this.cbNeon.Name = "cbNeon";
            this.cbNeon.Size = new System.Drawing.Size(55, 19);
            this.cbNeon.TabIndex = 4;
            this.cbNeon.Text = "Neon";
            this.cbNeon.UseVisualStyleBackColor = true;
            // 
            // cbRdWheels
            // 
            this.cbRdWheels.AutoSize = true;
            this.cbRdWheels.Location = new System.Drawing.Point(6, 47);
            this.cbRdWheels.Name = "cbRdWheels";
            this.cbRdWheels.Size = new System.Drawing.Size(112, 19);
            this.cbRdWheels.TabIndex = 3;
            this.cbRdWheels.Text = "Random Wheels";
            this.cbRdWheels.UseVisualStyleBackColor = true;
            // 
            // nudUpgradeChance
            // 
            this.nudUpgradeChance.Location = new System.Drawing.Point(80, 72);
            this.nudUpgradeChance.Name = "nudUpgradeChance";
            this.nudUpgradeChance.Size = new System.Drawing.Size(65, 23);
            this.nudUpgradeChance.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chance (%)";
            // 
            // cbRdColor
            // 
            this.cbRdColor.AutoSize = true;
            this.cbRdColor.Location = new System.Drawing.Point(73, 22);
            this.cbRdColor.Name = "cbRdColor";
            this.cbRdColor.Size = new System.Drawing.Size(103, 19);
            this.cbRdColor.TabIndex = 2;
            this.cbRdColor.Text = "Random Color";
            this.cbRdColor.UseVisualStyleBackColor = true;
            // 
            // cbVehicleUpgrade
            // 
            this.cbVehicleUpgrade.AutoSize = true;
            this.cbVehicleUpgrade.Location = new System.Drawing.Point(6, 22);
            this.cbVehicleUpgrade.Name = "cbVehicleUpgrade";
            this.cbVehicleUpgrade.Size = new System.Drawing.Size(61, 19);
            this.cbVehicleUpgrade.TabIndex = 1;
            this.cbVehicleUpgrade.Text = "Enable";
            this.cbVehicleUpgrade.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nudMidnight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudNight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudEvening);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudAfternoon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudMorning);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wait Time (seconds)";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Midnight";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Night";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evening";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Afternoon";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morning";
            // 
            // tlpTheTwoList
            // 
            this.tlpTheTwoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTheTwoList.ColumnCount = 2;
            this.tlpTheTwoList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpTheTwoList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTheTwoList.Controls.Add(this.groupBox6, 0, 0);
            this.tlpTheTwoList.Controls.Add(this.groupBox7, 1, 0);
            this.tlpTheTwoList.Location = new System.Drawing.Point(9, 192);
            this.tlpTheTwoList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTheTwoList.Name = "tlpTheTwoList";
            this.tlpTheTwoList.RowCount = 1;
            this.tlpTheTwoList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTheTwoList.Size = new System.Drawing.Size(766, 331);
            this.tlpTheTwoList.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudSwapChance);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.nudSwapDistance);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnDelSwap);
            this.groupBox6.Controls.Add(this.btnEditSwap);
            this.groupBox6.Controls.Add(this.btnAddSwap);
            this.groupBox6.Controls.Add(lvVehicleSwap);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(2, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox6.Size = new System.Drawing.Size(493, 327);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Model Swap (If New Model is blank, it will take a random model from the Model Lis" +
    "t)";
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
            this.nudSwapChance.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Swap Chance (%)";
            // 
            // nudSwapDistance
            // 
            this.nudSwapDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSwapDistance.Location = new System.Drawing.Point(268, 301);
            this.nudSwapDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSwapDistance.Name = "nudSwapDistance";
            this.nudSwapDistance.Size = new System.Drawing.Size(65, 23);
            this.nudSwapDistance.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Swap Distance";
            // 
            // btnDelSwap
            // 
            this.btnDelSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelSwap.Location = new System.Drawing.Point(452, 301);
            this.btnDelSwap.Name = "btnDelSwap";
            this.btnDelSwap.Size = new System.Drawing.Size(38, 23);
            this.btnDelSwap.TabIndex = 6;
            this.btnDelSwap.Text = "Del";
            this.btnDelSwap.UseVisualStyleBackColor = true;
            this.btnDelSwap.Click += new System.EventHandler(this.tsmiSwapDelete_Click);
            // 
            // btnEditSwap
            // 
            this.btnEditSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSwap.Location = new System.Drawing.Point(408, 301);
            this.btnEditSwap.Name = "btnEditSwap";
            this.btnEditSwap.Size = new System.Drawing.Size(38, 23);
            this.btnEditSwap.TabIndex = 5;
            this.btnEditSwap.Text = "Edit";
            this.btnEditSwap.UseVisualStyleBackColor = true;
            this.btnEditSwap.Click += new System.EventHandler(this.tsmiSwapEdit_Click);
            // 
            // btnAddSwap
            // 
            this.btnAddSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSwap.Location = new System.Drawing.Point(365, 301);
            this.btnAddSwap.Name = "btnAddSwap";
            this.btnAddSwap.Size = new System.Drawing.Size(38, 23);
            this.btnAddSwap.TabIndex = 4;
            this.btnAddSwap.Text = "Add";
            this.btnAddSwap.UseVisualStyleBackColor = true;
            this.btnAddSwap.Click += new System.EventHandler(this.tsmiSwapNew_Click);
            // 
            // lvVehicleSwap
            // 
            lvVehicleSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lvVehicleSwap.CheckBoxes = true;
            lvVehicleSwap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chOldVehicle,
            this.chNewVehicle});
            lvVehicleSwap.ContextMenuStrip = this.cmsVehicleSwap;
            lvVehicleSwap.FullRowSelect = true;
            lvVehicleSwap.HideSelection = false;
            lvVehicleSwap.Location = new System.Drawing.Point(3, 19);
            lvVehicleSwap.Name = "lvVehicleSwap";
            lvVehicleSwap.Size = new System.Drawing.Size(487, 276);
            lvVehicleSwap.TabIndex = 1;
            lvVehicleSwap.UseCompatibleStateImageBehavior = false;
            lvVehicleSwap.View = System.Windows.Forms.View.Details;
            lvVehicleSwap.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvVehicleSwap_ItemChecked);
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
            this.chOldVehicle.Width = 200;
            // 
            // chNewVehicle
            // 
            this.chNewVehicle.Text = "New Model";
            this.chNewVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNewVehicle.Width = 200;
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDelModel);
            this.groupBox7.Controls.Add(this.btnEditModel);
            this.groupBox7.Controls.Add(this.btnAddModel);
            this.groupBox7.Controls.Add(this.btnHelp);
            this.groupBox7.Controls.Add(lvModelList);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(499, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox7.Size = new System.Drawing.Size(265, 327);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Model List";
            // 
            // btnDelModel
            // 
            this.btnDelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelModel.Location = new System.Drawing.Point(224, 301);
            this.btnDelModel.Name = "btnDelModel";
            this.btnDelModel.Size = new System.Drawing.Size(38, 23);
            this.btnDelModel.TabIndex = 5;
            this.btnDelModel.Text = "Del";
            this.btnDelModel.UseVisualStyleBackColor = true;
            this.btnDelModel.Click += new System.EventHandler(this.tsmiListDelete_Click);
            // 
            // btnEditModel
            // 
            this.btnEditModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditModel.Location = new System.Drawing.Point(180, 301);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(38, 23);
            this.btnEditModel.TabIndex = 4;
            this.btnEditModel.Text = "Edit";
            this.btnEditModel.UseVisualStyleBackColor = true;
            this.btnEditModel.Click += new System.EventHandler(this.tsmiListEdit_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModel.Location = new System.Drawing.Point(137, 301);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(38, 23);
            this.btnAddModel.TabIndex = 3;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.tsmiListNew_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(3, 301);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lvModelList
            // 
            lvModelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lvModelList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chListNo,
            this.chListModel});
            lvModelList.ContextMenuStrip = this.cmsVehicleList;
            lvModelList.FullRowSelect = true;
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
            lvModelList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
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
            lvModelList.HideSelection = false;
            lvModelList.Location = new System.Drawing.Point(3, 19);
            lvModelList.Name = "lvModelList";
            lvModelList.Size = new System.Drawing.Size(259, 276);
            lvModelList.TabIndex = 1;
            lvModelList.UseCompatibleStateImageBehavior = false;
            lvModelList.View = System.Windows.Forms.View.Details;
            lvModelList.DoubleClick += new System.EventHandler(this.lvModelList_DoubleClick);
            // 
            // chListNo
            // 
            this.chListNo.Width = 0;
            // 
            // chListModel
            // 
            this.chListModel.Text = "Model";
            this.chListModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chListModel.Width = 200;
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(697, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.llblWeb.TabIndex = 8;
            this.llblWeb.TabStop = true;
            this.llblWeb.Text = "My GitHub";
            this.llblWeb.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llblWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWeb_LinkClicked);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.llblWeb);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tlpTheTwoList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tlpTheThreeGroups);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Added Traffic Redux Settings GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpTheThreeGroups.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpgradeChance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMidnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorning)).EndInit();
            this.tlpTheTwoList.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwapDistance)).EndInit();
            this.cmsVehicleSwap.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.cmsVehicleList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCruiseSpeed;
        private System.Windows.Forms.NumericUpDown nudSpawnDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbSpawnParkedVeh;
        private System.Windows.Forms.NumericUpDown nudMaxVeh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDrivingStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRoadType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbDebugText;
        private System.Windows.Forms.CheckBox cbBlip;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpTheThreeGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbNeon;
        private System.Windows.Forms.CheckBox cbRdWheels;
        private System.Windows.Forms.CheckBox cbRdColor;
        private System.Windows.Forms.CheckBox cbVehicleUpgrade;
        private System.Windows.Forms.NumericUpDown nudUpgradeChance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMidnight;
        private System.Windows.Forms.NumericUpDown nudNight;
        private System.Windows.Forms.NumericUpDown nudEvening;
        private System.Windows.Forms.NumericUpDown nudAfternoon;
        private System.Windows.Forms.NumericUpDown nudMorning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpTheTwoList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chOldVehicle;
        private System.Windows.Forms.ColumnHeader chNewVehicle;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleSwap;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwapDelete;
        private System.Windows.Forms.Button btnAddSwap;
        private System.Windows.Forms.Button btnDelSwap;
        private System.Windows.Forms.Button btnEditSwap;
        private System.Windows.Forms.NumericUpDown nudSwapDistance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudSwapChance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        public static ListViewX lvModelList;
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
        private System.Windows.Forms.Button btnDelModel;
        private System.Windows.Forms.Button btnEditModel;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llblWeb;
        public static System.Windows.Forms.ListView lvVehicleSwap;
        private System.Windows.Forms.ColumnHeader chListNo;
        private System.Windows.Forms.ColumnHeader chListModel;
    }
}