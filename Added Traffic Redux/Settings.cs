using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using GTA;
using GTA.Native;

namespace Added_Traffic_Redux
{
	public struct Settings
	{
		public Settings Instance
		{
			get
			{
				return ReadFromFile();
			}
		}

		[XmlIgnore]
		public string FileName { get; set; }

		public WaitTime WaitTime;
		public float CruiseSpeed;
		public float SpawnDistance;
		public int MaxVehicleAllow;
		public DrivingStyle DrivingStyle;
		public eNodeType RoadType;
		public bool SpawnParkedVehicle;
		public bool SupportCayoPerico;
		public bool Notify;
		public bool ShowBlip;
		public bool DebugText;
		public bool EnableUpgrade;
		public bool RandomizeWheels;
		public bool RandomizeColor;
		public bool EnableNeonUpgrade;
		public int UpgradeChance;
		public Vehicles Vehicles;
		public int SwapChance;
		public float SwapDistance;
		public List<VehicleSwap> VehicleSwaps;

		public Settings(string _fileName) : this()
		{
			FileName = _fileName;
		}

		public void Save()
		{
			var ser = new XmlSerializer(typeof(Settings));
			TextWriter writer = new StreamWriter(FileName);
			ser.Serialize(writer, this);
			writer.Close();
		}

		private Vehicles GenerateVehicleList()
		{
			var vehicles = new Vehicles();

			// City Center
			vehicles.Downtown = VehiclesList.DowntownVehList();

			// Rich place
			vehicles.Vinewood = VehiclesList.VinewoodVehList();

			// Gang place
			vehicles.SouthLosSantos = VehiclesList.SouthLosSantosVehList();

			// Port place
			vehicles.PortOfSouthLosSantos = VehiclesList.PortOfSouthLosSantosVehList();

			// Industrial
			vehicles.EastLosSantos = VehiclesList.EastLosSantosVehList();

			// Beach, tourist attraction
			vehicles.Vespucci = VehiclesList.VespucciVehList();

			// Los Santos city
			vehicles.LosSantos = VehiclesList.LosSantosVehList();

			// Offroad and dirty cars
			vehicles.GrandSenoraDesert = VehiclesList.GrandSenoraDesertVehList();

			// Mountain area
			vehicles.SanChianskiMountainRange = VehiclesList.SanChianskiMountainRangeVehList();

			// Offroad and dirty cars
			vehicles.BlaineCounty = VehiclesList.BlaineCountyVehList();

			// Army Base
			vehicles.FortZancudo = VehiclesList.FortZancudoVehList();

			// North Yankton
			vehicles.NorthYankton = VehiclesList.NorthYanktonVehList();

			// Cayo Perico
			vehicles.CayoPerico = VehiclesList.CayoPericoVehList();

			return vehicles;
		}

		public List<VehicleSwap> GenerateVehicleSwapList()
		{
			return new List<VehicleSwap>
			{
				new VehicleSwap("police", "dune4", false),
				new VehicleSwap("police2", "dune5", false),
				new VehicleSwap("police3", "dune4", false),
				new VehicleSwap("police4", "dune5", false),
				new VehicleSwap("policeb", "dune4", false),
				new VehicleSwap("policet", "dune5", false),
				new VehicleSwap("sheriff", "dune4", false),
				new VehicleSwap("sheriff2", "dune5", false)
			};
		}

		public Settings ReadFromFile()
		{
			if (!File.Exists(FileName))
			{
				return new Settings(FileName)
				{
					WaitTime = new WaitTime(15, 10, 15, 10, 20),
					CruiseSpeed = 20.0f,
					SpawnDistance = 150.0f,
					MaxVehicleAllow = 10,
					DrivingStyle = DrivingStyle.Normal,
					RoadType = eNodeType.AsphaltRoad,
					SpawnParkedVehicle = true,
					SupportCayoPerico = false,
					Notify = false,
					ShowBlip = false,
					DebugText = false,
					EnableUpgrade = true,
					RandomizeWheels = true,
					RandomizeColor = true,
					EnableNeonUpgrade = true,
					UpgradeChance = 20,
					Vehicles = GenerateVehicleList(),
					SwapChance = 100,
					SwapDistance = 100.0f,
					VehicleSwaps = GenerateVehicleSwapList()
				};
			}

			try
			{
				var ser = new XmlSerializer(typeof(Settings));
				TextReader reader = new StreamReader(FileName);
				var instance = (Settings)ser.Deserialize(reader);
				reader.Close();
				return instance;
			}
			catch (Exception ex)
			{
				return new Settings(FileName)
				{
					WaitTime = new WaitTime(15, 10, 15, 10, 20),
					CruiseSpeed = 20.0f,
					SpawnDistance = 150.0f,
					MaxVehicleAllow = 10,
					DrivingStyle = DrivingStyle.Normal,
					RoadType = eNodeType.AsphaltRoad,
					SpawnParkedVehicle = true,
					SupportCayoPerico = false,
					Notify = false,
					ShowBlip = false,
					DebugText = false,
					EnableUpgrade = true,
					RandomizeWheels = true,
					RandomizeColor = true,
					EnableNeonUpgrade = true,
					UpgradeChance = 20,
					Vehicles = GenerateVehicleList(),
					SwapChance = 1000,
					SwapDistance = 100.0f,
					VehicleSwaps = GenerateVehicleSwapList()
				};
			}
		}
	}

	public struct VehicleSwap
	{
		public string OldVehicle;
		public string NewVehicle;
		public bool Enable;

		public VehicleSwap(string ov, string nv, bool en = true)
		{
			OldVehicle = ov;
			NewVehicle = nv;
			Enable = en;
		}

		public VehicleSwap(string ov, bool en = true)
		{
			OldVehicle = ov;
			NewVehicle = null;
			Enable = en;
		}
	}

	public struct Vehicles
	{
		public List<string> Downtown;
		public List<string> Vinewood;
		public List<string> SouthLosSantos;
		public List<string> PortOfSouthLosSantos;
		public List<string> EastLosSantos;
		public List<string> Vespucci;
		public List<string> LosSantos;
		public List<string> GrandSenoraDesert;
		public List<string> SanChianskiMountainRange;
		public List<string> BlaineCounty;
		public List<string> FortZancudo;
		public List<string> NorthYankton;
		public List<string> CayoPerico;

		public Vehicles(List<string> dt, List<string> vw, List<string> sls, List<string> psls, List<string> els, List<string> ves, List<string> ls, List<string> gsd, List<string> scmr, List<string> bc, List<string> fz, List<string> ny, List<string> cp)
		{
			Downtown = dt;
			Vinewood = vw;
			SouthLosSantos = sls;
			PortOfSouthLosSantos = psls;
			EastLosSantos = els;
			Vespucci = ves;
			LosSantos = ls;
			GrandSenoraDesert = gsd;
			SanChianskiMountainRange = scmr;
			BlaineCounty = bc;
			FortZancudo = fz;
			NorthYankton = ny;
			CayoPerico = cp;
		}
	}

	public struct WaitTime
	{
		public int Morning;
		public int Afternoon;
		public int Evening;
		public int Night;
		public int Midnight;

		public WaitTime(int morn, int noon, int even, int nite, int midn)
		{
			Morning = morn;
			Afternoon = noon;
			Evening = even;
			Night = nite;
			Midnight = midn;
		}
	}

	public enum eNodeType
	{
		AsphaltRoad,
		SimplePath,
		UnderTheMap,
		Water
	}
}