using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using GTA;
using GTA.Math;

namespace Added_Traffic_Redux
{
	internal static class DevTools
	{
		// Shared
		public static bool devToolsEnabled = false;

		// CycleZoneCarGens
		public static string zone1 = null;
		public static int curCarGenIndex = 0;
		public static int max = 0;
		public static Type CarGens = typeof(CarGens);
		public static FieldInfo[] fields = null;
		public static List<Vector5> retrievedList = null;

		// CreateCarGenEntry
		public static string zone2 = null;

		public static void EnableDevTools()
		{
			if (!devToolsEnabled)
			{
				UI.Notify("~y~Added Traffic Redux~w~: Dev mode enabled");
				devToolsEnabled = true;
			}
			else
			{
				UI.Notify("~y~Added Traffic Redux~w~: Dev mode disabled");
				devToolsEnabled = false;
			}
		}

		public static void CycleZoneCarGens()
		{
			if (devToolsEnabled)
			{
				// Get all CarGen fields the first time this command is run
				if (fields == null)
				{
					fields = CarGens.GetFields();
				}

				Vector3 playerPos = Game.Player.Character.Position;
				string curZone = Helper.GetPlayerZone();
				string zoneName = World.GetZoneName(playerPos);

				// Check zone compared to curZone to see if we need to update variables
				if (zone1 != curZone)
				{
					// Reset and update variables
					curCarGenIndex = 0;
					zone1 = curZone;
					if (retrievedList != null) retrievedList.Clear();

					// Set custom Cayo Perico zone if in Cayo Perico
					if (Helper.supportCayoPerico && Helper.IsPlayerInCayoPerico()) curZone = "CAYO";

					//Find the correct field of values for the current zone and store them
					foreach (var field in fields)
					{
						if (field.Name == curZone)
						{
							object fieldObj = field.GetValue(null);
							retrievedList = (List<Vector5>)fieldObj;
							max = retrievedList.Count;
							break;
						}
					}
				}

				if (retrievedList.Count != 0)
				{
					// Teleport player to CarGen list's curCarGenIndex position and rotation
					var newPos = retrievedList[curCarGenIndex].Vector3;
					var newRot = retrievedList[curCarGenIndex].Vector2;
					if (Game.Player.Character.IsInVehicle())
					{
						Game.Player.Character.CurrentVehicle.Position = newPos;
						Game.Player.Character.CurrentVehicle.Rotation = new Vector3(0f, 0f, newRot.ToHeading());
					}
					else
					{
						Game.Player.Character.Position = newPos;
						Game.Player.Character.Rotation = new Vector3(0f, 0f, newRot.ToHeading());
					}

					// Add 1 to displayed index because list indexes start at 0
					if (Helper.supportCayoPerico && Helper.IsPlayerInCayoPerico()) UI.Notify($"Cayo Perico (CAYO) Vehicle Position: {curCarGenIndex + 1}/{max}");
					else UI.Notify($"{zoneName} ({zone1}) Vehicle Position: {curCarGenIndex + 1}/{max}");

					if (curCarGenIndex == max - 1) curCarGenIndex = 0;
					else curCarGenIndex++;
				}
				else UI.Notify($"No CarGens in {zoneName} ({zone1})");
			}
		}

		public static void CreateCarGenEntry()
		{
			if (devToolsEnabled)
			{
				if (Game.Player.Character.IsInVehicle())
				{
					Vector3 curVehPos = Game.Player.Character.CurrentVehicle.Position;
					Vector3 curVehRot = Game.Player.Character.CurrentVehicle.Rotation;
					Vector2 curVehOri = curVehRot.GetOrientation();
					string curZone = Helper.GetPlayerZone();
					bool zoneHasChanged = false;
					bool InCayoPerico = false;

					if (zone2 != curZone)
					{
						zone2 = curZone;
						zoneHasChanged = true;
					}

					// Set custom Cayo Perico zone if in Cayo Perico
					if (Helper.supportCayoPerico && Helper.IsPlayerInCayoPerico())
					{
						InCayoPerico = true;
						zone2 = curZone = "CAYO";
					}

					using(StreamWriter writer = new StreamWriter(@".\scripts\New Car Gens.txt", true))
					{
						if (zoneHasChanged)
						{
							writer.WriteLine("-----------------------------------------------------------------------------");
							writer.WriteLine("Zone ID: " + curZone);
						}
						writer.WriteLine("\tnew Vector5(new Vector3(" + curVehPos.X + "f, " + curVehPos.Y + "f, " + curVehPos.Z + "f), new Vector2(" + Math.Round(curVehOri.X, 6) + "f, " + Math.Round(curVehOri.Y, 6) + "f)),");
					}
					UI.Notify($"New entry saved for {zone2}");

					// Set back to SANAND if in Cayo Perico
					if (InCayoPerico) zone2 = "SANAND";
				}
				else UI.Notify("Must be in a vehicle to create a CarGen entry");
			}
		}

		public static void WriteError(this Exception ex)
		{
			using(StreamWriter writer = new StreamWriter(@".\scripts\Added Traffic Redux.log", true))
			{
				writer.WriteLine("-----------------------------------------------------------------------------");
				writer.WriteLine("Date : " + DateTime.Now.ToString());
				writer.WriteLine();

				while(ex != null)
				{
					writer.WriteLine(ex.GetType().FullName);
					writer.WriteLine(ex.ToString());

					ex = ex.InnerException;
				}
			}
		}
	}
}