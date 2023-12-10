using System;
using System.Reflection;
using System.Collections.Generic;

namespace Added_Traffic_Redux
{
	public static class VehiclesList
	{
		public static List<Type> dlcNameClasses = new List<Type> { typeof(mpBeachVehicleList), typeof(mpValentinesVehicleList), typeof(mpBusinessVehicleList),
																   typeof(mpBusiness2VehicleList), typeof(mpHipsterVehicleList), typeof(mpIndependanceVehicleList),
																   typeof(mpPilotVehicleList), typeof(mpLTSVehicleList), typeof(spUpgradeVehicleList),
																   typeof(mpChristmas2VehicleList), typeof(mpHeistVehicleList), typeof(mpLuxe1VehicleList),
																   typeof(mpLuxe2VehicleList), typeof(mpLowriderVehicleList), typeof(mpHalloweenVehicleList),
																   typeof(mpApartmentVehicleList), typeof(mpXmas_604490VehicleList), typeof(mpJanuary2016VehicleList),
																   typeof(mpValentines2VehicleList), typeof(mpLowrider2VehicleList), typeof(mpExecutiveVehicleList),
																   typeof(mpStuntVehicleList), typeof(mpBikerVehicleList), typeof(mpImportExportVehicleList),
																   typeof(mpSpecialRacesVehicleList), typeof(mpGunrunningVehicleList), typeof(mpSmugglerVehicleList),
																   typeof(mpChristmas2017VehicleList), typeof(mpAssaultVehicleList), typeof(mpBattleVehicleList),
																   typeof(mpChristmas2018VehicleList), typeof(mpVinewoodVehicleList), typeof(mpHeist3VehicleList),
																   typeof(mpSumVehicleList), typeof(mpHeist4VehicleList), typeof(mpTunerVehicleList),
																   typeof(mpSecurityVehicleList), typeof(mpG9ECVehicleList), typeof(mpSum2VehicleList),
																   typeof(mpChristmas3VehicleList), typeof(mp2023_01VehicleList) };

		public static List<string> DowntownVehList()
		{
			// Base Game Only
			List<string> DowntownVehicles = new List<string> { "tailgater", "buffalo2" };

			DowntownVehicles.AddDLCVehicles("Downtown");
			return DowntownVehicles;
		}

		public static List<string> VinewoodVehList()
		{
			// Base Game Only
			List<string> VinewoodVehicles = new List<string> {};

			VinewoodVehicles.AddDLCVehicles("Vinewood");
			return VinewoodVehicles;
		}

		public static List<string> SouthLosSantosVehList()
		{
			// Base Game Only
			List<string> SouthLosSantosVehicles = new List<string> { "gburrito" };

			SouthLosSantosVehicles.AddDLCVehicles("SouthLosSantos");
			return SouthLosSantosVehicles;
		}

		public static List<string> PortOfSouthLosSantosVehList()
		{
			// Base Game Only
			List<string> PortOfSouthLosSantosVehicles = new List<string> {};

			PortOfSouthLosSantosVehicles.AddDLCVehicles("PortOfSouthLosSantos");
			return PortOfSouthLosSantosVehicles;
		}

		public static List<string> EastLosSantosVehList()
		{
			// Base Game Only
			List<string> EastLosSantosVehicles = new List<string> {};

			EastLosSantosVehicles.AddDLCVehicles("EastLosSantos");
			return EastLosSantosVehicles;
		}

		public static List<string> VespucciVehList()
		{
			// Base Game Only
			List<string> VespucciVehicles = new List<string> {};

			VespucciVehicles.AddDLCVehicles("Vespucci");
			return VespucciVehicles;
		}

		public static List<string> LosSantosVehList()
		{
			// Base Game Only
			List<string> LosSantosVehicles = new List<string> { "buffalo2", "tailgater" };

			LosSantosVehicles.AddDLCVehicles("LosSantos");
			return LosSantosVehicles;
		}

		public static List<string> GrandSenoraDesertVehList()
		{
			// Base Game Only
			List<string> GrandSenoraDesertVehicles = new List<string> { "bodhi2" };

			GrandSenoraDesertVehicles.AddDLCVehicles("GrandSenoraDesert");
			return GrandSenoraDesertVehicles;
		}

		public static List<string> SanChianskiMountainRangeVehList()
		{
			// Base Game Only
			List<string> SanChianskiMountainRangeVehicles = new List<string> {};

			SanChianskiMountainRangeVehicles.AddDLCVehicles("SanChianskiMountainRange");
			return SanChianskiMountainRangeVehicles;
		}

		public static List<string> BlaineCountyVehList()
		{
			// Base Game Only
			List<string> BlaineCountyVehicles = new List<string> { "bodhi2" };

			BlaineCountyVehicles.AddDLCVehicles("BlaineCounty");
			return BlaineCountyVehicles;
		}

		public static List<string> FortZancudoVehList()
		{
			// Base Game Only
			List<string> FortZancudoVehicles = new List<string> {};

			FortZancudoVehicles.AddDLCVehicles("FortZancudo");
			return FortZancudoVehicles;
		}

		public static List<string> NorthYanktonVehList()
		{
			// Base Game Only
			List<string> NorthYanktonVehicles = new List<string> { "asea2", "burrito5", "emperor3", "tractor3", "mesa2", "rancherxl2", "sadler2", "stockade3" };

			return NorthYanktonVehicles;
		}

		public static List<string> CayoPericoVehList()
		{
			// Base Game Only
			List<string> CayoPericoVehicles = new List<string> {};

			CayoPericoVehicles.AddDLCVehicles("CayoPerico");
			return CayoPericoVehicles;
		}

		public static void AddDLCVehicles(this List<string> listToAddTo, string zoneName)
		{
			foreach (var type in dlcNameClasses)
			{
				FieldInfo[] fields = type.GetFields();

				foreach (var field in fields)
				{
					if (field.Name == zoneName)
					{
						object fieldObj = field.GetValue(null);
						List<string> retrievedList = (List<string>)fieldObj;
						listToAddTo.AddRange(retrievedList);
						break;
					}
				}
			}
		}
	}

	// Beach Bum Update (mpBeach) - November 19, 2013
	// Vehicle models: bifta|kalahari|paradise|speeder
	public class mpBeachVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		public static List<string> Vespucci = new List<string> { "bifta", "kalahari" };
		// public static List<string> LosSantos = new List<string> {};
		public static List<string> GrandSenoraDesert = new List<string> { "bifta" };
		public static List<string> SanChianskiMountainRange = new List<string> { "bifta" };
		public static List<string> BlaineCounty = new List<string> { "bifta" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Valentine's Day Massacre Special (mpValentines) - February 13, 2014
	// Vehicle models: btype
	public class mpValentinesVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "btype" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Business Update (mpBusiness) - March 4, 2014
	// Vehicle models: alpha|jester|turismor|vestra
	public class mpBusinessVehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The High Life Update (mpBusiness2) - May 12, 2014
	// Vehicle models: huntley|massacro|thrust|zentorno
	public class mpBusiness2VehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The "I'm Not a Hipster" Update (mpHipster) - June 17, 2014
	// Vehicle models: blade|dubsta3|glendale|panto|pigalle|rhapsody|warrener
	public class mpHipsterVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		public static List<string> SouthLosSantos = new List<string> { "dubsta3" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		public static List<string> GrandSenoraDesert = new List<string> { "dubsta3" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "dubsta3" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Independance Day Special (mpIndependance) - August 1, 2014
	// Vehicle models: monster|sovreign
	public class mpIndependanceVehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The San Andreas Flight School Update (mpPilot) - August 19, 2014
	// Vehicle models: besra|coquette2|miljet|swift
	public class mpPilotVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "coquette2" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Last Team Standing Update (mpLTS) - October 2, 2014
	// Vehicle models: furoregt|hakuchou|innovation
	public class mpLTSVehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Enhanced Edition (spUpgrade) - November 18, 2014 (Console)/April 14, 2015 (PC)
	// Vehicle models: blimp2|blista2|blista3|buffalo3|dodo|dominator2|dukes|dukes2|gauntlet2|marshall|stalion|stalion2|submersible2
	public class spUpgradeVehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Festive Surprise (mpChristmas2) - December 18, 2014
	// Vehicle models: jester2|massacro2|ratloader2|slamvan
	public class mpChristmas2VehicleList // NOTE: Spawns by default; only here to list it
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Heists (mpHeist) - March 10, 2015
	// Vehicle models: barracks3|boxville4|casco|dinghy3|enduro|gburrito2|guardian|hydra|insurgent|insurgent2|kuruma|kuruma2|lectro|mule3|savage|slamvan2|tanker2|technical|trash2|valkyrie|velum2
	public class mpHeistVehicleList
	{
		public static List<string> Downtown = new List<string> { "boxville4", "kuruma" };
		public static List<string> Vinewood = new List<string> { "casco", "lectro" };
		public static List<string> SouthLosSantos = new List<string> { "gburrito2", "slamvan2" };
		public static List<string> PortOfSouthLosSantos = new List<string> { "boxville4", "mule3" };
		public static List<string> EastLosSantos = new List<string> { "boxville4", "guardian", "mule3" };
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "boxville4", "kuruma" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		public static List<string> FortZancudo = new List<string> { "barracks3", "insurgent", "insurgent2", "technical" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Ill-Gotten Gains Part 1 (mpLuxe) - June 10, 2015
	// Vehicle models: feltzer3|luxor2|osiris|swift|virgo|windsor
	public class mpLuxe1VehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "feltzer3", "osiris", "windsor" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Ill-Gotten Gains Part 2 (mpLuxe2) - July 8, 2015
	// Vehicle models: brawler|chino|coquette3|t20|toro|vindicator
	public class mpLuxe2VehicleList
	{
		public static List<string> Downtown = new List<string> { "chino", "coquette3" };
		public static List<string> Vinewood = new List<string> { "t20", "toros", "vindicator" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "chino", "coquette3" };
		public static List<string> GrandSenoraDesert = new List<string> { "brawler" };
		public static List<string> SanChianskiMountainRange = new List<string> { "brawler" };
		public static List<string> BlaineCounty = new List<string> { "brawler" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Lowriders (mpLowrider) - October 20, 2015
	// Vehicle models: buccaneer2|chino2|faction|faction2|moonbeam|moonbeam2|primo2|voodoo
	public class mpLowriderVehicleList
	{
		public static List<string> Downtown = new List<string> { "faction", "moonbeam" };
		// public static List<string> Vinewood = new List<string> {};
		public static List<string> SouthLosSantos = new List<string> { "buccaneer2", "chino2", "faction2", "moonbeam2", "primo2", "voodoo" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "faction", "moonbeam" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Halloween Surprise (mpHalloween) - October 29, 2015
	// Vehicle models: btype2|lurcher
	public class mpHalloweenVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "btype2", "lurcher" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Executives and Other Criminals (mpApartment) - December 15, 2015
	// Vehicle models: baller3|baller4|baller5|baller6|cargobob4|cog55|cog552|cognoscenti|cognoscenti2|dinghy4|limo2|mamba|nightshade|schafter3|schafter4|schafter5|schafter6|seashark3|speeder2|supervolito2|supervolito|toro2|tropic2|valkyrie2|verlierer2
	public class mpApartmentVehicleList
	{
		public static List<string> Downtown = new List<string> { "baller3", "baller4", "nightshade", "schafter3", "schafter4", "verlierer2" };
		public static List<string> Vinewood = new List<string> { "baller3", "baller4", "cog55", "cognoscenti", "mamba" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "baller3", "baller4", "nightshade", "schafter3", "schafter4", "verlierer2" };
		public static List<string> GrandSenoraDesert = new List<string> { "baller3", "baller4" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "baller3", "baller4" };
		public static List<string> FortZancudo = new List<string> { "limo2" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Festive Surprise 2015 (mpXmas_604490) - December 21, 2015
	// Vehicle models: tampa
	public class mpXmas_604490VehicleList
	{
		public static List<string> Downtown = new List<string> { "tampa" };
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "tampa" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// January 2016 Update (mpJanuary2016) - January 28, 2016
	// Vehicle models: banshee2|sultanrs
	public class mpJanuary2016VehicleList
	{
		public static List<string> Downtown = new List<string> { "banshee2", "sultanrs" };
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		public static List<string> Vespucci = new List<string> { "banshee2", "sultanrs" };
		public static List<string> LosSantos = new List<string> { "banshee2", "sultanrs" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Be My Valentine (mpValentines2) - February 10, 2016
	// Vehicle models: btype3
	public class mpValentines2VehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "btype3" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Lowriders: Custom Classics (mpLowrider2) - March 15, 2016
	// Vehicle models: faction3|minivan2|sabregt2|slamvan3|tornado5|virgo2|virgo3
	public class mpLowrider2VehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		public static List<string> SouthLosSantos = new List<string> { "faction3", "minivan2", "sabregt2", "slamvan3", "tornado5", "virgo2", "virgo3" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Further Adventures in Finance and Felony (mpExecutive) - June 7, 2016
	// Vehicle models: bestiagts|brickade|fmj|nimbus|pfister811|prototipo|reaper|rumpo3|seven70|tug|volatus|windsor2|xls|xls2
	public class mpExecutiveVehicleList
	{
		public static List<string> Downtown = new List<string> { "xls" };
		public static List<string> Vinewood = new List<string> { "bestiagts", "fmj", "pfister811", "prototipo", "reaper", "seven70", "windsor2", "xls" };
		// public static List<string> SouthLosSantos = new List<string> {};
		public static List<string> PortOfSouthLosSantos = new List<string> { "rumpo3" };
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "xls" };
		public static List<string> GrandSenoraDesert = new List<string> { "rumpo3", "xls" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "rumpo3", "xls" };
		public static List<string> FortZancudo = new List<string> { "brickade" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Cunning Stunts (mpStunt) - July 12, 2016
	// Vehicle models: bf400|brioso|cliffhanger|contender|gargoyle|le7b|lynx|omnis|rallytruck|sheava|tampa2|trophytruck|trophytruck2|tropos|tyrus
	public class mpStuntVehicleList
	{
		public static List<string> Downtown = new List<string> { "brioso", "tampa2", "tropos" };
		public static List<string> Vinewood = new List<string> { "le7b", "lynx", "omnis", "sheava", "tyrus" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "brioso", "tampa2", "tropos" };
		public static List<string> GrandSenoraDesert = new List<string> { "bf400", "cliffhanger", "contender", "gargoyle", "rallytruck", "trophytruck", "trophytruck2" };
		public static List<string> SanChianskiMountainRange = new List<string> { "bf400", "cliffhanger", "gargoyle", "trophytruck", "trophytruck2" };
		public static List<string> BlaineCounty = new List<string> { "bf400", "cliffhanger", "contender", "gargoyle", "trophytruck", "trophytruck2" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Bikers (mpBiker) - October 4, 2016
	// Vehicle models: avarus|blazer4|chimera|daemon2|defiler|esskey|faggio|faggio3|hakuchou2|manchez|nightblade|raptor|ratbike|sanctus|shotaro|tornado6|vortex|wolfsbane|youga2|zombiea|zombieb
	public class mpBikerVehicleList
	{
		public static List<string> Downtown = new List<string> { "avarus", "chimera", "daemon2", "defiler", "esskey", "faggio", "faggio3", "raptor", "wolfsbane", "zombiea", "zombieb" };
		public static List<string> Vinewood = new List<string> { "hakuchou2", "nightblade", "sanctus", "shotaro", "vortex" };
		public static List<string> SouthLosSantos = new List<string> { "raptor" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		public static List<string> EastLosSantos = new List<string> { "youga2" };
		public static List<string> Vespucci = new List<string> { "raptor" };
		public static List<string> LosSantos = new List<string> { "avarus", "chimera", "daemon2", "defiler", "esskey", "faggio", "faggio3", "raptor", "wolfsbane", "zombiea", "zombieb" };
		public static List<string> GrandSenoraDesert = new List<string> { "blazer4", "esskey", "manchez", "ratbike", "tornado6", "wolfsbane", "youga2", "zombiea", "zombieb" };
		public static List<string> SanChianskiMountainRange = new List<string> { "blazer4", "manchez" };
		public static List<string> BlaineCounty = new List<string> { "blazer4", "esskey", "manchez", "ratbike", "tornado6", "wolfsbane", "youga2", "zombiea", "zombieb" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Import/Export (mpImportExport) - December 13, 2016
	// Vehicle models: blazer5|boxville5|comet3|diablous|diablous2|dune4|dune5|elegy|fcr|fcr2|italigtb2|italigtb|nero|nero2|penetrator|phantom2|ruiner2|ruiner3|specter|specter2|technical2|tempesta|voltic2|wastelander
	public class mpImportExportVehicleList
	{
		public static List<string> Downtown = new List<string> { "comet3", "diablous", "elegy", "fcr", "specter" };
		public static List<string> Vinewood = new List<string> { "diablous2", "fcr2", "italigtb", "italigtb2", "nero", "nero2", "penetrator", "ruiner2", "specter2", "tempesta", "voltic2" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		public static List<string> Vespucci = new List<string> { "comet3", "elegy",  };
		public static List<string> LosSantos = new List<string> { "comet3", "diablous", "elegy", "fcr", "specter" };
		public static List<string> GrandSenoraDesert = new List<string> { "blazer5" };
		public static List<string> SanChianskiMountainRange = new List<string> { "blazer5" };
		public static List<string> BlaineCounty = new List<string> { "blazer5", "wastelander" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Cunning Stunts: Special Vehicle Circuit (mpSpecialRaces) - March 14, 2017
	// Vehicle models: gp1|infernus2|ruston|turismo2
	public class mpSpecialRacesVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "gp1", "infernus2", "ruston", "turismo2" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Gunrunning (mpGunrunning) - June 13, 2017
	// Vehicle models: apc|ardent|caddy3|cheetah2|dune3|halftrack|hauler2|insurgent3|nightshark|oppressor|phantom3|tampa3|technical3|torero|trailerlarge|trailers4|trailersmall2|vagner|xa21
	public class mpGunrunningVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "ardent", "cheetah2", "oppressor", "torero", "vagner", "xa21" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		public static List<string> FortZancudo = new List<string> { "apc", "caddy3", "dune3", "halftrack", "insurgent3", "nightshark", "technical3" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Smuggler's Run (mpSmuggler) - August 29, 2017
	// Vehicle models: alphaz1|bombushka|cyclone|havok|howard|hunter|microlight|mogul|molotok|nokota|pyro|rapidgt3|retinue|rogue|seabreeze|starling|tula|vigilante|visione
	public class mpSmugglerVehicleList
	{
		public static List<string> Downtown = new List<string> { "rapidgt3", "retinue" };
		public static List<string> Vinewood = new List<string> { "cyclone", "visione" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "rapidgt3", "retinue" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Doomsday Heist (mpChristmas2017) - December 12, 2017
	// Vehicle models: akula|autarch|avenger|avenger2|barrage|chernobog|comet4|comet5|deluxo|gt500|hermes|hustler|kamacho|khanjali|neon|pariah|raiden|revolter|riata|riot2|savestra|sc1|sentinel3|streiter|stromberg|thruster|viseris|volatol|yosemite|z190
	public class mpChristmas2017VehicleList
	{
		public static List<string> Downtown = new List<string> { "deluxo", "hermes", "hustler", "savestra", "sentinel3", "streiter", "yosemite", "z190" };
		public static List<string> Vinewood = new List<string> { "autarch", "comet5", "gt500", "neon", "pariah", "raiden", "revolter", "sc1", "stromberg", "viseris" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "deluxo", "hermes", "hustler", "savestra", "sentinel3", "streiter", "yosemite", "z190" };
		public static List<string> GrandSenoraDesert = new List<string> { "comet4", "kamacho", "riata" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "comet4", "kamacho", "riata" };
		public static List<string> FortZancudo = new List<string> { "barrage", "chernobog", "khanjali", "riot2", "thruster" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Southern San Andreas Super Sport Series (mpAssault) - March 20, 2018
	// Vehicle models: caracara|cheburek|dominator3|ellie|entity2|fagaloa|flashgt|gb200|hotring|issi3|jester3|michelli|seasparrow|taipan|tezeract|tyrant
	public class mpAssaultVehicleList
	{
		public static List<string> Downtown = new List<string> { "cheburek", "dominator3", "ellie", "fagaloa", "flashgt", "gb200", "issi3", "jester3", "michelli" };
		public static List<string> Vinewood = new List<string> { "entity2", "taipan", "tezeract", "tyrant" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "cheburek", "dominator3", "ellie", "fagaloa", "flashgt", "gb200", "issi3", "jester3", "michelli" };
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		public static List<string> FortZancudo = new List<string> { "caracara" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// After Hours (mpBattle) - July 24, 2018
	// Vehicle models: blimp3|freecrawler|menacer|mule4|oppressor2|patriot2|pbus2|pounder2|scramjet|speedo4|stafford|strikeforce|swinger|terbyte
	public class mpBattleVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		public static List<string> Vinewood = new List<string> { "oppressor2", "patriot2", "pbus2", "scramjet", "stafford", "swinger" };
		// public static List<string> SouthLosSantos = new List<string> {};
		public static List<string> PortOfSouthLosSantos = new List<string> { "mule4", "pounder2", "speedo4", "terbyte" };
		public static List<string> EastLosSantos = new List<string> { "mule4", "pounder2", "speedo4", "terbyte" };
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		public static List<string> GrandSenoraDesert = new List<string> { "freecrawler" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "freecrawler" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Arena War (mpChristmas2018) - December 11, 2018
	// Vehicle models: bruiser|bruiser2|bruiser3|brutus|brutus2|brutus3|cerberus|cerberus2|cerberus3|clique|deathbike|deathbike2|deathbike3|deveste|deviant|dominator4|dominator5|dominator6|impaler|impaler2|impaler3|impaler4|imperator|imperator2|imperator3|issi4|issi5|issi6|italigto|monster3|monster4|monster5|rcbandito|scarab|scarab2|scarab3|schlagen|slamvan4|slamvan5|slamvan6|toros|tulip|vamos|zr380|zr3802|zr3803
	public class mpChristmas2018VehicleList
	{
		public static List<string> Downtown = new List<string> { "clique", "deviant", "impaler", "tulip", "vamos" };
		public static List<string> Vinewood = new List<string> { "deveste", "italigto", "schlagen" };
		public static List<string> SouthLosSantos = new List<string> { "brutus", "imperator" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "clique", "deviant", "impaler", "tulip", "vamos" };
		public static List<string> GrandSenoraDesert = new List<string> { "deathbike" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		public static List<string> FortZancudo = new List<string> { "scarab" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Diamond Casino & Resort (mpVinewood) - July 23, 2019
	// Vehicle models: caracara2|drafter|dynasty|emerus|gauntlet3|gauntlet4|hellion|issi7|jugular|krieger|locust|nebula|neo|novak|paragon|paragon2|peyote2|rrocket|s80|thrax|zion3|zorrusso
	public class mpVinewoodVehicleList
	{
		public static List<string> Downtown = new List<string> { "gauntlet3", "gauntlet4", "issi7", "nebula", "zion3" };
		public static List<string> Vinewood = new List<string> { "drafter", "dynasty", "emerus", "jugular", "krieger", "locust", "neo", "novak", "paragon", "s80", "thrax", "zorrusso" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "gauntlet3", "gauntlet4", "issi7", "nebula", "zion3" };
		public static List<string> GrandSenoraDesert = new List<string> { "caracara2", "hellion", "nebula", "peyote2", "rrocket" };
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		public static List<string> BlaineCounty = new List<string> { "caracara2", "hellion", "nebula", "peyote2", "rrocket" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Diamond Casino Heist (mpHeist3) - December 12, 2019
	// Vehicle models: asbo|everon|formula|formula2|furia|imorgon|jb7002|kanjo|komoda|minitank|outlaw|rebla|retinue2|stryder|sugoi|sultan2|vagrant|vstr|yosemite2|zhaba
	public class mpHeist3VehicleList
	{
		public static List<string> Downtown = new List<string> { "asbo", "kanjo", "retinue2", "sugoi", "sultan2", "yosemite2" };
		public static List<string> Vinewood = new List<string> { "furia", "imorgon", "jb7002", "komoda", "rebla", "vstr" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		public static List<string> Vespucci = new List<string> { "vagrant" };
		public static List<string> LosSantos = new List<string> { "asbo", "kanjo", "retinue2", "sugoi", "sultan2", "yosemite2" };
		public static List<string> GrandSenoraDesert = new List<string> { "everon", "outlaw", "stryder", "vagrant" };
		public static List<string> SanChianskiMountainRange = new List<string> { "stryder" };
		public static List<string> BlaineCounty = new List<string> { "everon", "outlaw", "stryder", "vagrant" };
		public static List<string> FortZancudo = new List<string> { "zhaba" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Los Santos Summer Special (mpSum) - August 11, 2020
	// Vehicle models: club|coquette4|dukes3|gauntlet5|glendale2|landstalker2|manana2|openwheel1|openwheel2|penumbra2|peyote3|seminole2|tigon|yosemite3|youga3
	public class mpSumVehicleList
	{
		public static List<string> Downtown = new List<string> { "club", "gauntlet5", "glendale2", "landstalker2", "manana2", "penumbra2" };
		public static List<string> Vinewood = new List<string> { "coquette4", "glendale2", "landstalker2", "manana2", "tigon" };
		public static List<string> SouthLosSantos = new List<string> { "peyote3",  };
		public static List<string> PortOfSouthLosSantos = new List<string> { "youga3" };
		public static List<string> EastLosSantos = new List<string> { "youga3" };
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "club", "gauntlet5", "glendale2", "landstalker2", "manana2", "penumbra2" };
		public static List<string> GrandSenoraDesert = new List<string> { "seminole2", "yosemite3" };
		public static List<string> SanChianskiMountainRange = new List<string> { "gauntlet5", "seminole2", "yosemite3" };
		public static List<string> BlaineCounty = new List<string> { "seminole2", "yosemite3" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Cayo Perico Heist (mpHeist4) - December 15, 2020
	// Vehicle models: alkonost|annihilator2|avisa|brioso2|dinghy5|italirsx|kosatka|longfin|manchez2|patrolboat|seasparrow2|seasparrow3|slamtruck|squaddie|toreador|verus|vetir|veto|veto2|weevil|winky
	public class mpHeist4VehicleList
	{
		public static List<string> Downtown = new List<string> { "brioso2", "weevil" };
		public static List<string> Vinewood = new List<string> { "italirsx", "slamtruck", "toreador", "weevil" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "weevil" };
		public static List<string> GrandSenoraDesert = new List<string> { "brioso2", "manchez2", "verus" };
		public static List<string> SanChianskiMountainRange = new List<string> { "brioso2", "manchez2", "verus" };
		public static List<string> BlaineCounty = new List<string> { "manchez2", "verus",  };
		public static List<string> FortZancudo = new List<string> { "squaddie", "vetir", "winky" };
		// public static List<string> NorthYankton = new List<string> {};
		public static List<string> CayoPerico = new List<string> { "manchez2", "squaddie", "verus", "vetir", "winky" };
	}

	// Los Santos Tuners (mpTuner) - July 20, 2021
	// Vehicle models: calico|comet6|cypher|dominator7|dominator8|euros|freightcar2|futo2|growler|jester4|previon|remus|rt3000|sultan3|tailgater2|vectre|warrener2|zr350
	public class mpTunerVehicleList
	{
		public static List<string> Downtown = new List<string> { "dominator7", "dominator8", "futo2", "previon", "remus", "sultan3", "warrener2", "zr350" };
		public static List<string> Vinewood = new List<string> { "comet6", "dominator8", "euros", "growler", "jester4", "rt3000", "tailgater2", "vectre" };
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "calico", "comet6", "cypher", "dominator7", "dominator8", "futo2", "growler", "previon", "remus", "rt3000", "sultan3", "tailgater2", "vectre", "warrener2", "zr350" };
		public static List<string> GrandSenoraDesert = new List<string> { "warrener2" };
		public static List<string> SanChianskiMountainRange = new List<string> { "warrener2" };
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Contract (mpSecurity) - December 15, 2021
	// Vehicle models: astron|baller7|buffalo4|champion|cinquemila|comet7|deity|granger2|ignus|iwagen|jubilee|mule5|patriot3|reever|shinobi|youga4|zeno
	public class mpSecurityVehicleList
	{
		public static List<string> Downtown = new List<string> { "baller7", "deity", "granger2", "iwagen", "jubilee", "reever", "shinobi" };
		public static List<string> Vinewood = new List<string> { "baller7", "buffalo4", "champion", "cinquemila", "comet7", "ignus", "zeno" };
		// public static List<string> SouthLosSantos = new List<string> {};
		public static List<string> PortOfSouthLosSantos = new List<string> { "mule5" };
		public static List<string> EastLosSantos = new List<string> { "mule5" };
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "astron", "baller7", "buffalo4", "cinquemila", "comet7", "deity", "granger2", "iwagen", "jubilee", "reever", "shinobi" };
		public static List<string> GrandSenoraDesert = new List<string> { "patriot3" };
		public static List<string> SanChianskiMountainRange = new List<string> { "granger2", "patriot3", "reever", "shinobi" };
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Expanded & Enhanced Edition (mpG9EC) - March 15, 2022
	// Vehicle models: arbitergt|astron2|cyclone2|ignus2|s95
	public class mpG9ECVehicleList
	{
		// public static List<string> Downtown = new List<string> {};
		// public static List<string> Vinewood = new List<string> {};
		// public static List<string> SouthLosSantos = new List<string> {};
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		// public static List<string> LosSantos = new List<string> {};
		// public static List<string> GrandSenoraDesert = new List<string> {};
		// public static List<string> SanChianskiMountainRange = new List<string> {};
		// public static List<string> BlaineCounty = new List<string> {};
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// The Criminal Enterprises (mpSum2) - July 26, 2022
	// Vehicle models: brioso3|conada|corsita|draugur|greenwood|kanjosj|lm87|omnisegt|postlude|rhinehart|ruiner4|sentinel4|sm722|tenf2|tenf|torero2|vigero2|weevil2
	public class mpSum2VehicleList
	{
		public static List<string> Downtown = new List<string> { "brioso3", "kanjosj", "postlude", "rhinehart", "sentinel4" };
		public static List<string> Vinewood = new List<string> { "corsita", "lm87", "omnisegt", "ruiner4", "sm722", "tenf2", "tenf", "torero2", "vigero2", "weevil2" };
		public static List<string> SouthLosSantos = new List<string> { "greenwood" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "kanjosj", "omnisegt", "postlude", "rhinehart", "ruiner4", "vigero2" };
		public static List<string> GrandSenoraDesert = new List<string> { "brioso3", "draugur", "sentinel4", "weevil2" };
		public static List<string> SanChianskiMountainRange = new List<string> { "brioso3", "draugur", "sentinel4", "weevil2" };
		public static List<string> BlaineCounty = new List<string> { "weevil2" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// Los Santos Drug Wars (mpChristmas3) - December 13, 2022
	// Vehicle models: boor|brickade2|broadway|cargoplane2|entity3|eudora|everon2|issi8|journey2|manchez3|panthere|powersurge|r300|surfer3|tahoma|tulip2|virtue
	public class mpChristmas3VehicleList
	{
		public static List<string> Downtown = new List<string> { "boor", "everon2", "panthere", "powersurge", "tahoma", "tulip2" };
		public static List<string> Vinewood = new List<string> { "broadway", "entity3", "r300", "virtue" };
		public static List<string> SouthLosSantos = new List<string> { "eudora" };
		// public static List<string> PortOfSouthLosSantos = new List<string> {};
		// public static List<string> EastLosSantos = new List<string> {};
		public static List<string> Vespucci = new List<string> { "surfer3" };
		public static List<string> LosSantos = new List<string> { "panthere", "powersurge", "r300" };
		public static List<string> GrandSenoraDesert = new List<string> { "boor", "issi8", "journey2", "manchez3" };
		public static List<string> SanChianskiMountainRange = new List<string> { "boor", "everon2", "issi8", "journey2", "manchez3", "powersurge", "surfer3" };
		public static List<string> BlaineCounty = new List<string> { "journey2", "manchez3" };
		public static List<string> FortZancudo = new List<string> { "brickade2" };
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}

	// San Andreas Mercenaries (mp2023_01) - June 13, 2023
	// Vehicle models: 216cstreamer|avenger3|avenger4|brigham|buffalo5|clique2|conada2|coureur|gauntlet6|inductor2|inductor|l35|monstrociti|raiju|ratel|speedo5|stingertt|streamer216
	public class mp2023_01VehicleList
	{
		public static List<string> Downtown = new List<string> { "coureur", "gauntlet6", "l35" };
		public static List<string> Vinewood = new List<string> { "brigham", "buffalo5", "clique2", "stingertt" };
		// public static List<string> SouthLosSantos = new List<string> {};
		public static List<string> PortOfSouthLosSantos = new List<string> { "speedo5" };
		public static List<string> EastLosSantos = new List<string> { "speedo5" };
		// public static List<string> Vespucci = new List<string> {};
		public static List<string> LosSantos = new List<string> { "buffalo5", "coureur", "gauntlet6", "stingertt" };
		public static List<string> GrandSenoraDesert = new List<string> { "l35", "ratel" };
		public static List<string> SanChianskiMountainRange = new List<string> { "coureur", "gauntlet6", "l35", "monstrociti", "ratel" };
		public static List<string> BlaineCounty = new List<string> { "l35" };
		// public static List<string> FortZancudo = new List<string> {};
		// public static List<string> NorthYankton = new List<string> {};
		// public static List<string> CayoPerico = new List<string> {};
	}
}