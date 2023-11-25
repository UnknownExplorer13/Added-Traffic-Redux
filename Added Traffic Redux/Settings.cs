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
		public DrivingStyle DrivingStyle;
		public bool EnableUpgrade;
		public int UpgradeChance;
		public bool EnableNeonUpgrade;
		public bool RandomizeColor;
		public bool RandomizeWheels;
		public int SwapChance;
		public float SwapDistance;
		public bool Notify;
		public bool ShowBlip;
		public bool DebugText;
		public eNodeType RoadType;
		public List<VehicleSwap> VehicleSwaps;
		public Vehicles Vehicles;
		public bool SpawnParkedVehicle;
		public int MaxVehicleAllow;

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
			vehicles.Downtown = new List<string> { "sultanrs", "banshee2", "specter", "elegy", "comet3", "raptor", "tampa2", "tropos", "schafter3", "schafter4", "verlierer2", "kuruma", "tampa", "faction",
												   "chino", "moonbeam", "nightshade", "coquette3", "fcr", "diablous", "zombieb", "zombiea", "wolfsbane", "faggio3", "faggio", "esskey", "defiler", "daemon2",
												   "chimera", "avarus", "xls", "baller4", "baller3", "brioso", "tailgater", "buffalo2", "yosemite", "ellie", "dominator3", "clique", "deviant", "impaler", "tulip",
												   "vamos", "gauntlet3", "gauntlet4", "yosemite2", "sentinel3", "flashgt", "gb200", "issi7", "sugoi", "sultan2", "rapidgt3", "retinue", "deluxo", "hermes",
												   "hustler", "savestra", "z190", "cheburek", "jester3", "michelli", "fagaloa", "nebula", "zion3", "retinue2", "streiter", "issi3", "asbo", "kanjo", "boxville4" };

			// Rich place
			vehicles.Vinewood = new List<string> { "tempesta", "penetrator", "nero2", "nero", "italigtb2", "italigtb", "le7b", "sheava", "tyrus", "reaper", "prototipo", "pfister811", "fmj", "t20", "osiris",
												   "fcr2", "diablous2", "vortex", "specter2", "sanctus", "nightblade", "hakuchou2", "vindicator", "xls", "baller4", "btype3", "mamba", "btype2", "feltzer3",
												   "casco", "coquette2", "btype", "omnis", "lynx", "seven70", "bestiagts", "baller3", "windsor2", "windsor", "cognoscenti", "cog55", "ruston", "comet5", "neon",
												   "pariah", "raiden", "revolter", "schlagen", "drafter", "jugular", "locust", "paragon", "imorgon", "komoda", "vstr", "oppressor", "oppressor2", "infernus2",
												   "turismo2", "ardent", "cheetah2", "torero", "gt500", "stromberg", "viseris", "stafford", "swinger", "dynasty", "jb7002", "patriot2", "toros", "novak", "rebla",
												   "voltic2", "gp1", "vagner", "xa21", "cyclone", "visione", "autarch", "sc1", "entity2", "tyrant", "tezeract", "taipan", "scramjet", "deveste", "italigto",
												   "emerus", "krieger", "neo", "s80", "thrax", "zorrusso", "furia", "pbus2", "shotaro", "lectro", "ruiner2" };

			// Gang place
			vehicles.SouthLosSantos = new List<string> { "dubsta3", "raptor", "virgo3", "virgo2", "tornado5", "slamvan3", "sabregt2", "minivan2", "faction3", "voodoo", "primo2", "moonbeam2", "faction2",
														 "chino2", "buccaneer2", "brutus", "imperator", "gburrito", "gburrito2", "slamvan2" };

			// Port place
			vehicles.PortOfSouthLosSantos = new List<string> { "rumpo3", "speedo4", "boxville4", "mule4", "pounder2", "terbyte", "mule3" };

			// Industrial
			vehicles.EastLosSantos = new List<string> { "youga2", "speedo4", "mule4", "pounder2", "terbyte", "boxville4", "guardian", "mule3" };

			// Beach, tourist attraction
			vehicles.Vespucci = new List<string> { "sultanrs", "banshee2", "kalahari", "bifta", "elegy", "comet3", "raptor", "vagrant" };

			// Los santos city
			vehicles.LosSantos = new List<string> { "sultanrs", "banshee2", "specter", "elegy", "comet3", "raptor", "tampa2", "tropos", "schafter3", "schafter4", "verlierer2", "kuruma", "tampa", "faction",
													"chino", "moonbeam", "nightshade", "coquette3", "fcr", "diablous", "zombieb", "zombiea", "wolfsbane", "faggio3", "faggio", "esskey", "defiler", "daemon2",
													"chimera", "avarus", "xls", "baller4", "baller3", "brioso", "tailgater", "buffalo2", "yosemite", "ellie", "dominator3", "clique", "deviant", "impaler", "tulip",
													"vamos", "gauntlet3", "gauntlet4", "yosemite2", "sentinel3", "flashgt", "gb200", "issi7", "sugoi", "sultan2", "rapidgt3", "retinue", "deluxo",
													"hermes", "hustler", "savestra", "z190", "cheburek", "jester3", "michelli", "fagaloa", "nebula", "zion3", "retinue2", "streiter", "issi3", "asbo", "kanjo",
													"boxville4" };

			// Offroad and dirty cars
			vehicles.GrandSenoraDesert = new List<string> { "brawler", "dubsta3", "bifta", "youga2", "rumpo3", "zombieb", "zombiea", "wolfsbane", "tornado6", "ratbike", "manchez", "esskey", "bf400",
															"cliffhanger", "gargoyle", "contender", "xls", "baller4", "baller3", "bodhi2", "trophytruck", "trophytruck2", "blazer4", "blazer5", "kamacho",
															"riata", "freecrawler", "caracara2", "hellion", "everon", "outlaw", "vagrant", "peyote2", "rrocket", "stryder", "nebula", "comet4", "deathbike",
															"rallytruck" };

			// Mountain area
			vehicles.SanChianskiMountainRange = new List<string> { "brawler", "bifta", "manchez", "bf400", "cliffhanger", "gargoyle", "trophytruck", "trophytruck2", "blazer4", "blazer5", "stryder" };

			// Offroad and dirty cars
			vehicles.BlaineCounty = new List<string> { "brawler", "dubsta3", "bifta", "youga2", "rumpo3", "zombieb", "zombiea", "wolfsbane", "tornado6", "ratbike", "manchez", "esskey", "bf400", "cliffhanger",
														"gargoyle", "contender", "xls", "baller4", "baller3", "bodhi2", "trophytruck", "trophytruck2", "blazer4", "blazer5", "kamacho", "riata", "freecrawler",
														"caracara2", "hellion", "everon", "outlaw", "vagrant", "peyote2", "comet4", "rrocket", "stryder", "nebula", "wastelander" };

			// Army Base
			vehicles.FortZancudo = new List<string> { "limo2", "caracara", "barrage", "chernobog", "khanjali", "riot2", "thruster", "scarab", "brickade", "apc", "caddy3", "dune3", "halftrack", "insurgent",
													  "insurgent2", "insurgent3", "nightshark", "technical3", "barracks3", "technical", "zhaba" };

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
					DrivingStyle = DrivingStyle.Normal,
					EnableUpgrade = true,
					UpgradeChance = 20,
					RandomizeColor = true,
					SwapChance = 100,
					SwapDistance = 100.0f,
					Notify = false,
					ShowBlip = false,
					RoadType = eNodeType.AsphaltRoad,
					Vehicles = GenerateVehicleList(),
					VehicleSwaps = GenerateVehicleSwapList(),
					RandomizeWheels = true,
					EnableNeonUpgrade = true,
					SpawnParkedVehicle = true,
					MaxVehicleAllow = 10,
					DebugText = false
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
					DrivingStyle = DrivingStyle.Normal,
					EnableUpgrade = true,
					UpgradeChance = 20,
					RandomizeColor = true,
					SwapChance = 1000,
					SwapDistance = 100.0f,
					Notify = false,
					ShowBlip = false,
					RoadType = eNodeType.AsphaltRoad,
					Vehicles = GenerateVehicleList(),
					VehicleSwaps = GenerateVehicleSwapList(),
					RandomizeWheels = true,
					EnableNeonUpgrade = true,
					SpawnParkedVehicle = true,
					MaxVehicleAllow = 10,
					DebugText = false
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

		public Vehicles(List<string> dt, List<string> vw, List<string> sls, List<string> psls, List<string> els, List<string> ves, List<string> ls, List<string> gsd, List<string> scmr, List<string> bc, List<string> fz)
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