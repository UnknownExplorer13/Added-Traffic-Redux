using System;
using System.IO;
using System.Linq;
using GTA;
using Metadata;

namespace Added_Traffic_Redux
{
	public class Traffic : Script
	{
		public Traffic()
		{
			Helper.LoadSettings();
			Tick += OnTick;
			Aborted += OnAbort;
		}

		private void OnTick(object sender, EventArgs e)
		{
			if (!Decor.Registered(Helper.modDecor, Decor.eDecorType.Bool))
			{
				Decor.Unlock();
				Decor.Register(Helper.modDecor, Decor.eDecorType.Bool);
				Decor.Lock();
			}

			if (!(Helper.GetPlayerZoneVehicleList().Count == 0))
			{
				if ((DateTime.Now - Helper.Now1).TotalSeconds > Helper.GetCurrentWaitTime() & !Game.IsLoading && !Game.IsPaused && Helper.HowManyVehiclesSpawnedByModOnWorldRightNow() <= Helper.maxVehicles)
				{
					if (!(Helper.GetPlayerZone() == "OCEANA")) Helper.SpawnVehicle();

					if (!(Helper.GetPlayerZone() == "HORS" | Helper.GetPlayerZone() == "LDAM" | Helper.GetPlayerZone() == "LACT" | Helper.GetPlayerZone() == "MTJOSE" | Helper.GetPlayerZone() == "CALAFB" | Helper.GetPlayerZone() == "BRADP" | Helper.GetPlayerZone() == "ELGORL" | Helper.GetPlayerZone() == "BRADT" | Helper.GetPlayerZone() == "OCEANA"))
					{
						if (Helper.spawnParkedVehicles) Helper.SpawnParkedVehicle();
					}

					Helper.Now1 = DateTime.Now;
				}

				World.GetAllVehicles().ClearVehicles();
				World.GetAllPeds().ClearPeds();
			}

			if (Helper.debugText)
			{
				if (Game.Player.Character.IsInVehicle())
				{
					var sz = Helper.GetSafeZoneSize();
					var v = Game.Player.Character.LastVehicle;
					var t = Helper.GetVehicleNodeProperties(v.Position);
					var r = Helper.IsOnRoad(v);
					var p = v.Position;
					var z = Helper.GetPlayerZone();
					var c = Helper.HowManyVehiclesSpawnedByModOnWorldRightNow();
					string str = $"Street: {World.GetStreetName(v.Position)} ({z})   Density: {t.Item1}   Flag: {t.Item2}   On Road: {r}   Position: x {p.X}, y {p.Y}, z {p.Z}   Count: {c}";
					var uit = new UIText(str, sz, 0.4f, System.Drawing.Color.White, Font.ChaletLondon, false, true, true);
					uit.Draw();
				}
			}

			if (!(Helper.vehicleSwaps.Count() == 0))
			{
				if ((DateTime.Now - Helper.Now2).TotalSeconds > Helper.GetCurrentWaitTime() && !Game.IsLoading && !Game.IsPaused && Helper.HowManyVehiclesSpawnedByModOnWorldRightNow() <= Helper.maxVehicles)
				{
					if (!(Helper.GetPlayerZone() == "OCEANA"))
					{
						Helper.SwapVehicleHaveDriver();
						Helper.SwapParkedVehicle();
					}

					Helper.Now2 = DateTime.Now;
				}
			}

			if (File.GetLastWriteTime(".\\scripts\\AddedTrafficRedux.xml") != Helper.XMLFileDate)
			{
				UI.Notify($"Added Traffic Redux settings refreshed.");
				Helper.config = new Settings(".\\scripts\\AddedTrafficRedux.xml").Instance;
				Helper.LoadSettings();
				Helper.XMLFileDate = File.GetLastWriteTime(".\\scripts\\AddedTrafficRedux.xml");
			}
		}

		private void OnAbort(object sender, EventArgs e)
		{
			var spawnVehicles = World.GetAllVehicles();

			for (int v = 0, loopTo = spawnVehicles.Count() - 1; v <= loopTo; v++)
			{
				if (Helper.IsVehicleSpawnedByMod(spawnVehicles[v]) && !(Game.Player.Character.CurrentVehicle == spawnVehicles[v]))
				{
					for (int p = 0, loopTo1 = spawnVehicles[v].PassengerCount - 1; p <= loopTo1; p++)
					{
						spawnVehicles[v].Passengers[p].Delete();
					}
					spawnVehicles[v].Delete();
				}
			}

			var spawnPeds = World.GetAllPeds();
			for (int p = 0, loopTo2 = spawnPeds.Count() - 1; p <= loopTo2; p++)
			{
				Ped ped = spawnPeds[p];
				if (Helper.IsPedSpawnByMod(ped)) spawnPeds[p].Delete();
			}
		}
	}
}