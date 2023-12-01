using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Added_Traffic_Redux_Settings.Forms
{
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			base.Load += frmSettings_Load;
			InitializeComponent();
		}

		private void tsmiListEdit_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				var fl = new frmList(this);
				fl.ListViewItem = item;
				fl.Category = item.Group.Header;
				fl.Model = item.SubItems[1].Text;
				fl.IsEdit = true;
				fl.Show();
			}
		}

		private void tsmiListNew_Click(object sender, EventArgs e)
		{
			var fl = new frmList(this);
			fl.IsEdit = false;
			fl.Show();
		}

		private void tsmiListDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems) lvModelList.Items.Remove(item);
			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiSwapNew_Click(object sender, EventArgs e)
		{
			var fs = new frmSwap(this);
			fs.vehSwap = new VehicleSwap();
			fs.IsEdit = false;
			fs.Show();
		}

		private void tsmiSwapEdit_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvVehicleSwap.SelectedItems)
			{
				var fs = new frmSwap(this);
				fs.ListViewItem = item;
				fs.vehSwap = (VehicleSwap)item.Tag;
				fs.IsEdit = true;
				fs.Show();
			}
		}

		private void tsmiSwapDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvVehicleSwap.SelectedItems) lvVehicleSwap.Items.Remove(item);
			lvVehicleSwap.Striped();
		}

		private void lvVehicleSwap_DoubleClick(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvVehicleSwap.SelectedItems)
			{
				item.Checked = !item.Checked;
				var fs = new frmSwap(this);
				fs.ListViewItem = item;
				fs.vehSwap = (VehicleSwap)item.Tag;
				fs.IsEdit = true;
				fs.Show();
			}
		}

		private void lvModelList_DoubleClick(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				var fl = new frmList(this);
				fl.ListViewItem = item;
				fl.Category = item.Group.Header;
				fl.Model = item.SubItems[1].Text;
				fl.IsEdit = true;
				fl.Show();
			}
		}

		private void tsmiDT_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Downtown"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiVW_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Vinewood"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiSLS_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["South Los Santos"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiPSLS_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Port of South Los Santos"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiELS_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["East Los Santos"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiVPC_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Vespucci"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiLS_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Los Santos"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiGSD_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Grand Senora Desert"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiSCMR_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["San Chianski Mountain Range"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiBC_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Blaine County"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void tsmiFZ_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in lvModelList.SelectedItems)
			{
				ListViewItem newItem = (ListViewItem)item.Clone();
				newItem.Group = lvModelList.Groups["Fort Zancudo"];
				lvModelList.Items.Add(newItem);
			}

			lvModelList.Striped();
			lvModelList.AddGroupFooter();
		}

		private void frmSettings_Load(object sender, EventArgs e)
		{
			if (File.Exists(@".\Added Traffic Redux.xml"))
			{
				var settings = new Settings(@".\Added Traffic Redux.xml").Instance;

				nudMorning.Value = settings.WaitTime.Morning;
				nudAfternoon.Value = settings.WaitTime.Afternoon;
				nudEvening.Value = settings.WaitTime.Evening;
				nudNight.Value = settings.WaitTime.Night;
				nudMidnight.Value = settings.WaitTime.Midnight;

				nudCruiseSpeed.Value = (decimal)settings.CruiseSpeed;
				nudSpawnDistance.Value = (decimal)settings.SpawnDistance;
				nudMaxVeh.Value = settings.MaxVehicleAllow;
				cmbDrivingStyle.Text = settings.DrivingStyle;
				cmbRoadType.Text = settings.RoadType;
				cbSpawnParkedVeh.Checked = settings.SpawnParkedVehicle;

				cbNotify.Checked = settings.Notify;
				cbBlip.Checked = settings.ShowBlip;
				cbDebugText.Checked = settings.DebugText;

				cbVehicleUpgrade.Checked = settings.EnableUpgrade;
				cbRdWheels.Checked = settings.RandomizeWheels;
				cbRdColor.Checked = settings.RandomizeColor;
				cbNeon.Checked = settings.EnableNeonUpgrade;
				nudUpgradeChance.Value = settings.UpgradeChance;

				nudSwapChance.Value = settings.SwapChance;
				nudSwapDistance.Value = (decimal)settings.SwapDistance;

				foreach (var vs in settings.VehicleSwaps)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(vs.OldVehicle);
					lvi.SubItems.Add(vs.NewVehicle);
					lvi.Checked = vs.Enable;
					lvi.Tag = vs;
					lvVehicleSwap.Items.Add(lvi);
				}
				lvVehicleSwap.Striped();

				Vehicles vehList = settings.Vehicles;
				foreach (var ml in vehList.Downtown)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Downtown"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.Vinewood)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Vinewood"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.SouthLosSantos)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["South Los Santos"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.PortOfSouthLosSantos)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Port of South Los Santos"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.EastLosSantos)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["East Los Santos"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.Vespucci)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Vespucci"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.LosSantos)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Los Santos"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.GrandSenoraDesert)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Grand Senora Desert"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.SanChianskiMountainRange)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["San Chianski Mountain Range"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.BlaineCounty)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Blaine County"];
					lvModelList.Items.Add(lvi);
				}
				foreach (var ml in vehList.FortZancudo)
				{
					var lvi = new ListViewItem("");
					lvi.SubItems.Add(ml);
					lvi.Group = lvModelList.Groups["Fort Zancudo"];
					lvModelList.Items.Add(lvi);
				}

				lvModelList.Striped();
				lvModelList.AddGroupFooter();
			}
			else
			{
				var result = MessageBox.Show($"Added Traffic Redux.xml not found, do you want to create it?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (result == DialogResult.Yes)
				{
					var settings = new Settings(@".\Added Traffic Redux.xml").Instance;
					settings.FileName = @".\Added Traffic Redux.xml";
					settings.Save();

					nudMorning.Value = settings.WaitTime.Morning;
					nudAfternoon.Value = settings.WaitTime.Afternoon;
					nudEvening.Value = settings.WaitTime.Evening;
					nudNight.Value = settings.WaitTime.Night;
					nudMidnight.Value = settings.WaitTime.Midnight;

					nudCruiseSpeed.Value = (decimal)settings.CruiseSpeed;
					nudSpawnDistance.Value = (decimal)settings.SpawnDistance;
					nudMaxVeh.Value = settings.MaxVehicleAllow;
					cmbDrivingStyle.Text = settings.DrivingStyle;
					cmbRoadType.Text = settings.RoadType;
					cbSpawnParkedVeh.Checked = settings.SpawnParkedVehicle;

					cbNotify.Checked = settings.Notify;
					cbBlip.Checked = settings.ShowBlip;
					cbDebugText.Checked = settings.DebugText;

					cbVehicleUpgrade.Checked = settings.EnableUpgrade;
					cbRdWheels.Checked = settings.RandomizeWheels;
					cbRdColor.Checked = settings.RandomizeColor;
					cbNeon.Checked = settings.EnableNeonUpgrade;
					nudUpgradeChance.Value = settings.UpgradeChance;

					nudSwapChance.Value = settings.SwapChance;
					nudSwapDistance.Value = (decimal)settings.SwapDistance;

					foreach (var vs in settings.VehicleSwaps)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(vs.OldVehicle);
						lvi.SubItems.Add(vs.NewVehicle);
						lvi.Checked = vs.Enable;
						lvi.Tag = vs;
						lvVehicleSwap.Items.Add(lvi);
					}
					lvVehicleSwap.Striped();

					Vehicles vehList = settings.Vehicles;
					foreach (var ml in vehList.Downtown)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Downtown"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.Vinewood)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Vinewood"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.SouthLosSantos)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["South Los Santos"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.PortOfSouthLosSantos)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Port of South Los Santos"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.EastLosSantos)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["East Los Santos"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.Vespucci)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Vespucci"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.LosSantos)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Los Santos"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.GrandSenoraDesert)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Grand Senora Desert"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.SanChianskiMountainRange)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["San Chianski Mountain Range"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.BlaineCounty)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Blaine County"];
						lvModelList.Items.Add(lvi);
					}
					foreach (var ml in vehList.FortZancudo)
					{
						var lvi = new ListViewItem("");
						lvi.SubItems.Add(ml);
						lvi.Group = lvModelList.Groups["Fort Zancudo"];
						lvModelList.Items.Add(lvi);
					}

					lvModelList.Striped();
					lvModelList.AddGroupFooter();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var newSetting = new Settings(@".\Added Traffic Redux.xml");
			newSetting.WaitTime = new WaitTime((int)nudMorning.Value, (int)nudAfternoon.Value, (int)nudEvening.Value, (int)nudNight.Value, (int)nudMidnight.Value);
			newSetting.CruiseSpeed = (float)nudCruiseSpeed.Value;
			newSetting.SpawnDistance = (float)nudSpawnDistance.Value;
			newSetting.DrivingStyle = cmbDrivingStyle.Text;
			newSetting.RoadType = cmbRoadType.Text;
			newSetting.RandomizeColor = cbRdColor.Checked;
			newSetting.RandomizeWheels = cbRdWheels.Checked;
			newSetting.Notify = cbNotify.Checked;
			newSetting.ShowBlip = cbBlip.Checked;
			newSetting.EnableUpgrade = cbVehicleUpgrade.Checked;
			newSetting.UpgradeChance = (int)nudUpgradeChance.Value;
			newSetting.SwapChance = (int)nudSwapChance.Value;
			newSetting.SwapDistance = (float)nudSwapDistance.Value;
			newSetting.EnableNeonUpgrade = cbNeon.Checked;
			newSetting.SpawnParkedVehicle = cbSpawnParkedVeh.Checked;
			newSetting.MaxVehicleAllow = (int)nudMaxVeh.Value;
			newSetting.DebugText = cbDebugText.Checked;

			var mSwap = new List<VehicleSwap>();
			foreach (ListViewItem item in lvVehicleSwap.Items) mSwap.Add((VehicleSwap)item.Tag);
			newSetting.VehicleSwaps = mSwap;

			var dt = new List<string>();
			var vw = new List<string>();
			var sls = new List<string>();
			var psls = new List<string>();
			var els = new List<string>();
			var vpc = new List<string>();
			var ls = new List<string>();
			var gsd = new List<string>();
			var scmr = new List<string>();
			var bc = new List<string>();
			var fz = new List<string>();

			foreach (ListViewGroup group in lvModelList.Groups)
			{
				foreach (ListViewItem item in group.Items)
				{
					switch (group.Name)
					{
						case "Downtown":
						{
							dt.Add(item.SubItems[1].Text);
							break;
						}
						case "Vinewood":
						{
							vw.Add(item.SubItems[1].Text);
							break;
						}
						case "South Los Santos":
						{
							sls.Add(item.SubItems[1].Text);
							break;
						}
						case "Port of South Los Santos":
						{
							psls.Add(item.SubItems[1].Text);
							break;
						}
						case "East Los Santos":
						{
							els.Add(item.SubItems[1].Text);
							break;
						}
						case "Vespucci":
						{
							vpc.Add(item.SubItems[1].Text);
							break;
						}
						case "Los Santos":
						{
							ls.Add(item.SubItems[1].Text);
							break;
						}
						case "Grand Senora Desert":
						{
							gsd.Add(item.SubItems[1].Text);
							break;
						}
						case "San Chianski Mountain Range":
						{
							scmr.Add(item.SubItems[1].Text);
							break;
						}
						case "Blaine County":
						{
							bc.Add(item.SubItems[1].Text);
							break;
						}
						case "Fort Zancudo":
						{
							fz.Add(item.SubItems[1].Text);
							break;
						}
					}
				}
			}

			var mList = new Vehicles();
			mList.Downtown = dt;
			mList.Vinewood = vw;
			mList.SouthLosSantos = sls;
			mList.PortOfSouthLosSantos = psls;
			mList.EastLosSantos = els;
			mList.Vespucci = vpc;
			mList.LosSantos = ls;
			mList.GrandSenoraDesert = gsd;
			mList.SanChianskiMountainRange = scmr;
			mList.BlaineCounty = bc;
			mList.FortZancudo = fz;
			newSetting.Vehicles = mList;
			newSetting.Save();

			MessageBox.Show("Saved successfully.", "Save", default, MessageBoxIcon.Information);
		}

		private void llblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/UnknownExplorer13");
		}

		private void lvVehicleSwap_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			VehicleSwap vehSwap = (VehicleSwap)e.Item.Tag;
			vehSwap.Enable = e.Item.Checked;
			e.Item.Tag = vehSwap;
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			string helpText = "Downtown\n" + "Downtown, Legion Square, Mission Row, Pillbox Hill, and Textile City\n\n" +
			"Vinewood\n" + "Alta, Downtown Vinewood, East Vinewood, GWC and Golfing Society, Hawick, Mirror Park, Richman Glen, Richman, Rockford Hills, Vinewood Hills, Vinewood Racetrack, Vinewood, and West Vinewood\n\n" +
			"South Los Santos\n" + "Chamberlain Hills, Davis, Rancho, and Strawberry\n\n" +
			"Port of South Los Santos\n" + "Banning, Elysian Island, Port of South Los Santos, and Terminal\n\n" +
			"East Los Santos\n" + "Cypress Flats, El Burro Heights, La Mesa, and Murrieta Heights\n\n" +
			"Vespucci\n" + "Puerto Del Sol, Vespucci Beach, Vespucci Canals, and Vespucci\n\n" +
			"Los Santos\n" + "Banham Canyon, Chumash, Del Perro Beach, Del Perro, Great Chaparral, L.S.I.A., La Puerta, Land Act Dam, Land Act Reservoir, Little Seoul, Maze Bank Arena, Morningwood, N.O.O.S.E, Pacific Bluffs, Palomino Highlands, Richards Majestic, Tataviam Mountains, Tongva Hills, and Tongva Valley\n\n" +
			"Grand Senora Desert\n" + "Bolingbroke Penitentiary, Grand Senora Desert, and Redwood Lights Track\n\n" +
			"San Chianski Mountain Range\n" + "Davis Quartz, Humane Labs and Research, Palmer-Taylor Power Station, RON Alternates Wind Farm, and San Chianski Mountain Range\n\n" +
			"Blaine County\n" + "Alamo Sea, Braddock Pass, Braddock Tunnel, Calafia Bridge, Cassidy Creek, Chiliad Mountain State Wilderness, El Gordo Lighthouse, Fort Zancudo, Galilee, Grapeseed, Harmony, Lago Zancudo, Mount Chiliad, Mount Gordo, Mount Josiah, North Chumash, Paleto Bay, Paleto Cove, Paleto Forest, Procopio Beach, Raton Canyon, Sandy Shores, Stab City, and Zancudo River\n\n" +
			"Fort Zancudo\n" + "Fort Zancudo Only";

			MessageBox.Show(helpText, "Help", default, MessageBoxIcon.Question);
		}
    }
}