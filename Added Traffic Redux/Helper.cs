using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using GTA;
using GTA.Math;
using GTA.Native;
using Metadata;

namespace Added_Traffic_Redux
{
	internal static class Helper
	{
		public static string nitroModDecor = "inm_nitro_active";
		public static string modDecor = "inm_traffic";
		public static Random rdVehicle, rdColor, rdMod, rdSpawn, rdSwap, rdWheel;
		public static DateTime Now1 = DateTime.Now;
		public static DateTime Now2 = DateTime.Now;
		public static DateTime XMLFileDate = File.GetLastWriteTime(@".\scripts\Added Traffic Redux.xml");

		// Settings
		public static Settings config = new Settings(@".\scripts\Added Traffic Redux.xml").Instance;
		public static WaitTime waitTime = new WaitTime(15, 10, 15, 10, 5);
		public static float cruiseSpeed = 20.0f;
		public static float spawnDistance = 150.0f;
		public static DrivingStyle drivingStyle = DrivingStyle.Normal;
		public static bool enableUpgrade = true;
		public static int upgradeChance = 20;
		public static bool randomizeColor = true;
		public static bool randomizeWheels = true;
		public static bool enableNeon = true;
		public static int swapChance = 50;
		public static float swapDistance = 100.0f;
		public static bool notify = true;
		public static bool showBlip = true;
		public static eNodeType roadType = eNodeType.AsphaltRoad;
		public static Vehicles vehicles;
		public static List<VehicleSwap> vehicleSwaps = new List<VehicleSwap>();
		public static List<Model> vehicleSwaps2;
		public static bool spawnParkedVehicles;
		public static int maxVehicles = 10;
		public static bool debugText;

		public static void LoadSettings()
		{
			CreateConfig();
			waitTime = config.WaitTime;
			cruiseSpeed = config.CruiseSpeed;
			spawnDistance = config.SpawnDistance;
			drivingStyle = config.DrivingStyle;
			enableUpgrade = config.EnableUpgrade;
			upgradeChance = config.UpgradeChance;
			randomizeColor = config.RandomizeColor;
			randomizeWheels = config.RandomizeWheels;
			enableNeon = config.EnableNeonUpgrade;
			swapChance = config.SwapChance;
			swapDistance = config.SwapDistance;
			notify = config.Notify;
			showBlip = config.ShowBlip;
			roadType = config.RoadType;
			vehicles = config.Vehicles;
			vehicleSwaps = config.VehicleSwaps;
			vehicleSwaps2 = new List<Model> {};
			foreach (var veh in vehicleSwaps)
			{
				if (veh.Enable) vehicleSwaps2.Add(new Model(veh.OldVehicle));
			}
			spawnParkedVehicles = config.SpawnParkedVehicle;
			maxVehicles = config.MaxVehicleAllow;
			debugText = config.DebugText;
		}

		public static void CreateConfig()
		{
			if (!File.Exists(@".\scripts\Added Traffic Redux.xml"))
			{
				config.FileName = @".\scripts\Added Traffic Redux.xml";
				config.Save();
			}
		}

		public static bool IsVehicleSpawnedByMod(Vehicle veh)
		{
			if (veh.GetBool(modDecor) == default) return false;
			return veh.GetBool(modDecor);
		}

		public static bool IsPedSpawnByMod(this Ped ped)
		{
			return ped.GetBool(modDecor);
		}

		public static void SetVehicleIsSpawnByMod(this Vehicle veh)
		{
			veh.SetBool(modDecor, true);
		}

		public static void SetPedIsSpawnByMod(this Ped ped)
		{
			ped.SetBool(modDecor, true);
		}

		public static void SetAsCop(this Ped ped)
		{
			GTA.Native.Function.Call(Hash.SET_PED_AS_COP, ped, true);
		}

		public static void SwapVehicleHaveDriverOffScreen()
		{
			var gpclv = Game.Player.Character.LastVehicle;
			var gpcp = Game.Player.Character.Position;

			var query = from v in World.GetAllVehicles()
						where v.IsPersistent == false & !v.Model.IsBoat & !v.Model.IsHelicopter & !v.Model.IsTrain & !v.Model.IsPlane & !IsVehicleSpawnedByMod(v) & !(v == gpclv) & !v.IsSeatFree(VehicleSeat.Driver) & v.Position.DistanceTo(gpcp) <= swapDistance & !v.IsOnScreen & vehicleSwaps2.Contains(v.Model)
						select v;

			if (query.Count() != 0)
			{
				Vehicle veh = query.FirstOrDefault();

				if (veh == default)
				{
					SwapVehicleHaveDriverOffScreen();
					return;
				}
				else
				{
					rdSwap = new Random();
					int schance = rdSwap.Next(0, 100);
					if (schance >= 0 && schance <= swapChance)
					{
						string modelString = vehicleSwaps.Where(x => new Model(x.OldVehicle) == veh.Model).FirstOrDefault().NewVehicle;
						if (string.IsNullOrEmpty(modelString))
						{
							if (!(GetPlayerZoneVehicleList().Count == 0))
							{
								rdVehicle = new Random();
								modelString = GetPlayerZoneVehicleList()[rdVehicle.Next(0, GetPlayerZoneVehicleList().Count)];
							}
							else return;
						}

						var model = new Model(modelString);
						model.Request(250);
						if (model.IsInCdImage && model.IsValid)
						{
							while (!model.IsLoaded) Script.Wait(50);

							string vehFriendlyName = Convert.ToString(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName);

							Ped driver = veh.Driver;
							driver.IsPersistent = true;
							Ped[] passengers = veh.Passengers;
							bool isCop = driver.IsInPoliceVehicle;
							driver.AlwaysKeepTask = false;

							Vehicle newveh = World.CreateVehicle(model, veh.Position, veh.Heading);
							veh.SetNoCollision(newveh, true);

							newveh.EngineRunning = true;
							driver.SetIntoVehicle(newveh, VehicleSeat.Driver);
							driver.SetPedIsSpawnByMod();
							driver.IsPersistent = false;
							driver.Task.CruiseWithVehicle(newveh, cruiseSpeed, (int)drivingStyle);
							driver.MarkAsNoLongerNeeded();

							foreach (Ped pass in passengers)
							{
								pass.SetIntoVehicle(newveh, pass.SeatIndex);
								pass.MarkAsNoLongerNeeded();
							}

							newveh.IsPersistent = veh.IsPersistent;
							newveh.SetVehicleIsSpawnByMod();
							newveh.LockStatus = veh.LockStatus;
							newveh.ForwardSpeed(veh.Speed);
							newveh.Velocity = veh.Velocity;

							veh.Delete();

							if (!randomizeColor) newveh.PaintVehicle();
							if (enableUpgrade)
							{
								rdMod = new Random();
								int chance = rdMod.Next(0, 100);
								if (chance >= 0 && chance <= upgradeChance)
								{
									int fullOrRandom = rdMod.Next(0, 100);
									switch (fullOrRandom)
									{
										case var @case when 0 <= @case && @case <= 50:
										{
											newveh.FullyUpgradeVehicle();
											break;
										}

										default:
										{
											newveh.RandomlyUpgradeVehicle();
											break;
										}
									}
								}
							}
							if (showBlip)
							{
								newveh.AddBlip();
								newveh.CurrentBlip.Color = BlipColor.YellowDark;
								newveh.CurrentBlip.Name = newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName;
							}
							if (notify) UI.Notify($"~b~{vehFriendlyName}~w~ was swapped with ~y~{(newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName)}~w~ at {World.GetStreetName(newveh.Position)}.");
							model.MarkAsNoLongerNeeded();
							newveh.MarkAsNoLongerNeeded();
						}
						else UI.Notify($"{modelString} is not a valid model.");
					}
					else veh.SetVehicleIsSpawnByMod();
				}
			}
		}
	
		public static void SwapVehicleHaveDriver()
		{
			var gpclv = Game.Player.Character.LastVehicle;
			var gpcp = Game.Player.Character.Position;

			var query = from v in World.GetAllVehicles()
						where v.IsPersistent == false & !v.Model.IsBoat & !v.Model.IsHelicopter & !v.Model.IsTrain & !v.Model.IsPlane & !IsVehicleSpawnedByMod(v) & !(v == gpclv) & !v.IsSeatFree(VehicleSeat.Driver) & v.Position.DistanceTo(gpcp) <= swapDistance & v.Position.DistanceTo(gpcp) >= swapDistance / 2f & vehicleSwaps2.Contains(v.Model)
						select v;

			if (query.Count() != 0)
			{
				Vehicle veh = query.FirstOrDefault();

				if (veh == default)
				{
					SwapVehicleHaveDriver();
					return;
				}
				else
				{
					rdSwap = new Random();
					int schance = rdSwap.Next(0, 100);
					if (schance >= 0 && schance <= swapChance)
					{
						string modelString = vehicleSwaps.Where(x => new Model(x.OldVehicle) == veh.Model).FirstOrDefault().NewVehicle;
						if (string.IsNullOrEmpty(modelString))
						{
							if (!(GetPlayerZoneVehicleList().Count == 0))
							{
								rdVehicle = new Random();
								modelString = GetPlayerZoneVehicleList()[rdVehicle.Next(0, GetPlayerZoneVehicleList().Count)];
							}
							else return;
						}

						var model = new Model(modelString);
						model.Request(250);
						if (model.IsInCdImage && model.IsValid)
						{
							while (!model.IsLoaded) Script.Wait(50);

							string vehFriendlyName = Convert.ToString(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName);

							Ped driver = veh.Driver;
							driver.IsPersistent = true;
							Ped[] passengers = veh.Passengers;
							bool isCop = driver.IsInPoliceVehicle;
							driver.AlwaysKeepTask = false;

							Vehicle newveh = World.CreateVehicle(model, veh.Position, veh.Heading);
							veh.SetNoCollision(newveh, true);

							newveh.EngineRunning = true;
							driver.SetIntoVehicle(newveh, VehicleSeat.Driver);
							driver.SetPedIsSpawnByMod();
							driver.IsPersistent = false;
							driver.Task.CruiseWithVehicle(newveh, cruiseSpeed, (int)drivingStyle);
							driver.MarkAsNoLongerNeeded();

							foreach (Ped pass in passengers)
							{
								pass.SetIntoVehicle(newveh, pass.SeatIndex);
								pass.MarkAsNoLongerNeeded();
							}

							newveh.IsPersistent = veh.IsPersistent;
							newveh.SetVehicleIsSpawnByMod();
							newveh.LockStatus = veh.LockStatus;
							newveh.ForwardSpeed(veh.Speed);
							newveh.Velocity = veh.Velocity;

							veh.Delete();

							if (!randomizeColor) newveh.PaintVehicle();
							if (enableUpgrade)
							{
								rdMod = new Random();
								int chance = rdMod.Next(0, 100);
								if (chance >= 0 && chance <= upgradeChance)
								{
									int fullOrRandom = rdMod.Next(0, 100);
									switch (fullOrRandom)
									{
										case var @case when 0 <= @case && @case <= 50:
										{
											newveh.FullyUpgradeVehicle();
											break;
										}

										default:
										{
											newveh.RandomlyUpgradeVehicle();
											break;
										}
									}
								}
							}
							if (showBlip)
							{
								newveh.AddBlip();
								newveh.CurrentBlip.Color = BlipColor.YellowDark;
								newveh.CurrentBlip.Name = newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName;
							}
							if (notify) UI.Notify($"~b~{vehFriendlyName}~w~ was swapped with ~y~{(newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName)}~w~ at {World.GetStreetName(newveh.Position)}.");
							model.MarkAsNoLongerNeeded();
							newveh.MarkAsNoLongerNeeded();
						}
						else UI.Notify($"{modelString} is not a valid model.");
					}
					else veh.SetVehicleIsSpawnByMod();
				}
			}
			else
			{
				SwapVehicleHaveDriverOffScreen();
				return;
			}
		}
	
		public static void SwapParkedVehicle()
		{
			var gpclv = Game.Player.Character.LastVehicle;
			var gpcp = Game.Player.Character.Position;

			var query = from v in World.GetAllVehicles()
						where v.IsPersistent == false & !v.Model.IsBoat & !v.Model.IsHelicopter & !v.Model.IsTrain & !v.Model.IsPlane & !IsVehicleSpawnedByMod(v) & !(v == gpclv) & v.IsSeatFree(VehicleSeat.Driver) & v.IsStopped & !v.EngineRunning & !v.IsOnScreen & vehicleSwaps2.Contains(v.Model)
						select v;

			if (query.Count() != 0)
			{
				Vehicle veh = query.FirstOrDefault();

				if (veh == default)
				{
					SwapParkedVehicle();
					return;
				}
				else
				{
					rdSwap = new Random();
					int schance = rdSwap.Next(0, 100);
					if (schance >= 0 && schance <= swapChance)
					{
						string modelString = vehicleSwaps.Where(x => new Model(x.OldVehicle) == veh.Model).FirstOrDefault().NewVehicle;
						if (string.IsNullOrEmpty(modelString))
						{
							if (!(GetPlayerZoneVehicleList().Count == 0))
							{
								rdVehicle = new Random();
								modelString = GetPlayerZoneVehicleList()[rdVehicle.Next(0, GetPlayerZoneVehicleList().Count)];
							}
							else return;
						}

						var model = new Model(modelString);
						model.Request(250);
						if (model.IsInCdImage && model.IsValid)
						{
							while (!model.IsLoaded) Script.Wait(50);

							string vehFriendlyName = Convert.ToString(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName);

							Vehicle newveh = World.CreateVehicle(model, veh.Position, veh.Heading);
							veh.SetNoCollision(newveh, true);

							newveh.IsPersistent = veh.IsPersistent;
							newveh.SetVehicleIsSpawnByMod();
							veh.HasAlarm = true;
							veh.LockStatus = VehicleLockStatus.CanBeBrokenInto;
							veh.NeedsToBeHotwired = true;

							veh.Delete();

							if (!randomizeColor) newveh.PaintVehicle();
							if (enableUpgrade)
							{
								rdMod = new Random();
								int chance = rdMod.Next(0, 100);
								if (chance >= 0 && chance <= upgradeChance)
								{
									int fullOrRandom = rdMod.Next(0, 100);
									switch (fullOrRandom)
									{
										case var @case when 0 <= @case && @case <= 50:
										{
											newveh.FullyUpgradeVehicle();
											break;
										}

										default:
										{
											newveh.RandomlyUpgradeVehicle();
											break;
										}
									}
								}
							}
							if (showBlip)
							{
								newveh.AddBlip();
								newveh.CurrentBlip.Color = BlipColor.Yellow;
								newveh.CurrentBlip.Name = newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName;
							}
							if (notify) UI.Notify($"~b~{vehFriendlyName}~w~ was swapped with ~y~{(newveh.FriendlyName == "NULL" ? newveh.DisplayName : newveh.FriendlyName)}(P)~w~ at {World.GetStreetName(veh.Position)}.");
							model.MarkAsNoLongerNeeded();
							newveh.MarkAsNoLongerNeeded();
						}
						else UI.Notify($"{modelString} is not a valid model.");
					}
					else veh.SetVehicleIsSpawnByMod();
				}
			}
		}
	
		public static void SpawnVehicle()
		{
			rdVehicle = new Random();
			string modelString = GetPlayerZoneVehicleList()[rdVehicle.Next(0, GetPlayerZoneVehicleList().Count)];
			var model = new Model(modelString);
			model.Request(250);
			if (model.IsInCdImage && model.IsValid)
			{
				while (!model.IsLoaded) Script.Wait(50);

				Vector3 forward = Game.Player.Character.Position + Game.Player.Character.ForwardVector * spawnDistance;
				Vector3 left = Game.Player.Character.Position - Game.Player.Character.RightVector * spawnDistance;
				Vector3 right = Game.Player.Character.Position + Game.Player.Character.RightVector * spawnDistance;
				var coords = default(Vector3);

				rdSpawn = new Random();
				switch (rdSpawn.Next(0, 100))
				{
					case var @case when 0 <= @case && @case <= 33:
					{
						coords = World.GetNextPositionOnStreet(forward, false);
						break;
					}
					case var case1 when 34 <= case1 && case1 <= 66:
					{
						coords = World.GetNextPositionOnStreet(left, false);
						break;
					}
					case var case2 when 67 <= case2 && case2 <= 100:
					{
						coords = World.GetNextPositionOnStreet(right, false);
						break;
					}
				}

				Vector3 closestVehicleNodeCoords = Vector3.Zero;
				float roadHeading = 0f;
				OutputArgument tempCoords = new OutputArgument(), tempRoadHeading = new OutputArgument();

				GTA.Native.Function.Call<Vector3>(Hash.GET_CLOSEST_VEHICLE_NODE_WITH_HEADING, coords.X, coords.Y, coords.Z, tempCoords, tempRoadHeading, (int)roadType, 3.0f, 0);
				closestVehicleNodeCoords = tempCoords.GetResult<Vector3>();
				roadHeading = tempRoadHeading.GetResult<float>();

				if (closestVehicleNodeCoords.DistanceTo(Game.Player.Character.Position) < spawnDistance / 2f)
				{
					SpawnVehicle();
					return;
				}

				Vehicle veh = World.CreateVehicle(model, closestVehicleNodeCoords, roadHeading);
				Ped driver = default;
				try
				{
					veh.Position = veh.Position + veh.RightVector * 3;
					driver = veh.CreateRandomPedOnSeat(VehicleSeat.Driver);
					if (!driver.IsHuman) driver = veh.CreateRandomPedOnSeat(VehicleSeat.Driver);
					if (driver.IsInPoliceVehicle)
					{
						driver = World.CreatePed(PedHash.Cop01SMY, veh.Position);
						driver.Task.WarpIntoVehicle(veh, VehicleSeat.Driver);
						driver.SetAsCop();
						driver.Weapons.Give(WeaponHash.Pistol, 9999, true, true);
						driver.Weapons.Give(WeaponHash.PumpShotgun, 9999, false, true);
						driver.Weapons.Give(WeaponHash.CarbineRifle, 9999, false, true);
						driver.Weapons.Give(WeaponHash.MicroSMG, 9999, false, true);
						driver.Weapons.Give(WeaponHash.AssaultShotgun, 9999, false, true);
						driver.Armor = 100;
					}
					driver.SetPedIsSpawnByMod();
					driver.IsPersistent = false;
					driver.Task.CruiseWithVehicle(veh, cruiseSpeed, (int)drivingStyle);
				}
				catch (Exception ex)
				{
					if (veh != default) veh.Delete();
					if (driver != default) driver.Delete();
					SpawnVehicle();
					return;
				}
	
				veh.EngineRunning = true;
				veh.IsPersistent = false;
				veh.SetVehicleIsSpawnByMod();
				if (!randomizeColor) veh.PaintVehicle();
				if (enableUpgrade)
				{
					rdMod = new Random();
					int chance = rdMod.Next(0, 100);
					if (chance >= 0 && chance <= upgradeChance)
					{
						int fullOrRandom = rdMod.Next(0, 100);
						switch (fullOrRandom)
						{
							case var case3 when 0 <= case3 && case3 <= 50:
							{
								veh.FullyUpgradeVehicle();
								break;
							}

							default:
							{
								veh.RandomlyUpgradeVehicle();
								break;
							}
						}
					}
				}
				if (showBlip)
				{
					veh.AddBlip();
					veh.CurrentBlip.Color = BlipColor.GreenDark;
					veh.CurrentBlip.Name = veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName;
				}
				if (notify) UI.Notify($"~g~{(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName)}~w~ was spawned at {World.GetStreetName(veh.Position)}.");
				model.MarkAsNoLongerNeeded();
				veh.MarkAsNoLongerNeeded();
				driver.MarkAsNoLongerNeeded();
			}
			else UI.Notify($"{modelString} is not a valid model.");
		}
	
		public static void SpawnParkedVehicle()
		{
			rdVehicle = new Random();
			string modelString = GetPlayerZoneVehicleList()[rdVehicle.Next(0, GetPlayerZoneVehicleList().Count)];
			var model = new Model(modelString);
			model.Request(250);
			if (model.IsInCdImage && model.IsValid)
			{
				while (!model.IsLoaded) Script.Wait(50);

				Vector3 forward = Game.Player.Character.Position + Game.Player.Character.ForwardVector * spawnDistance;
				Vector3 left = Game.Player.Character.Position - Game.Player.Character.RightVector * spawnDistance;
				Vector3 right = Game.Player.Character.Position + Game.Player.Character.RightVector * spawnDistance;
				var coords = default(Vector3);

				rdSpawn = new Random();
				switch (rdSpawn.Next(0, 100))
				{
					case var @case when 0 <= @case && @case <= 33:
					{
						coords = World.GetNextPositionOnStreet(forward, true);
						break;
					}
					case var case1 when 34 <= case1 && case1 <= 66:
					{
						coords = World.GetNextPositionOnStreet(left, true);
						break;
					}
					case var case2 when 67 <= case2 && case2 <= 100:
					{
						coords = World.GetNextPositionOnStreet(right, true);
						break;
					}
				}

				var parkingSpotPos = coords.GetNearestParkingSpot();

				if (object.ReferenceEquals(parkingSpotPos, Vector5.Zero()))
				{
					model.MarkAsNoLongerNeeded();
					SpawnVehicle();
					return;
				}

				if (parkingSpotPos.Vector3.IsPositionOccupied(5.0f))
				{
					model.MarkAsNoLongerNeeded();
					SpawnVehicle();
					return;
				}

				if (parkingSpotPos.Vector3.DistanceTo(Game.Player.Character.Position) < spawnDistance / 2f)
				{
					model.MarkAsNoLongerNeeded();
					SpawnVehicle();
					return;
				}

				Vehicle veh = World.CreateVehicle(model, parkingSpotPos.Vector3, parkingSpotPos.Vector2.ToHeading());

				veh.EngineRunning = false;
				veh.IsPersistent = false;
				veh.HasAlarm = true;
				veh.LockStatus = VehicleLockStatus.CanBeBrokenInto;
				veh.NeedsToBeHotwired = true;
				veh.SetVehicleIsSpawnByMod();
				if (!randomizeColor) veh.PaintVehicle();
				if (enableUpgrade)
				{
					rdMod = new Random();
					int chance = rdMod.Next(0, 100);
					if (chance >= 0 && chance <= upgradeChance)
					{
						int fullOrRandom = rdMod.Next(0, 100);
						switch (fullOrRandom)
						{
							case var case3 when 0 <= case3 && case3 <= 50:
							{
								veh.FullyUpgradeVehicle();
								break;
							}

							default:
							{
								veh.RandomlyUpgradeVehicle();
								break;
							}
						}
					}
				}
				if (showBlip)
				{
					veh.AddBlip();
					veh.CurrentBlip.Color = BlipColor.Green;
					veh.CurrentBlip.Name = veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName;
				}
				if (notify) UI.Notify($"~g~{(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName)}(P)~w~ was spawned at {World.GetStreetName(veh.Position)}.");
				model.MarkAsNoLongerNeeded();
				veh.MarkAsNoLongerNeeded();
			}
			else UI.Notify($"{modelString} is not a valid model.");
		}
	
		public static void FullyUpgradeVehicle(this Vehicle veh)
		{
			rdWheel = new Random();

			veh.InstallModKit();
			veh.SetMod((VehicleMod)43, veh.GetModCount((VehicleMod)43) - 1, true);
			veh.SetMod((VehicleMod)40, veh.GetModCount((VehicleMod)40) - 1, true);
			veh.SetMod((VehicleMod)42, veh.GetModCount((VehicleMod)42) - 1, true);
			veh.SetMod((VehicleMod)16, veh.GetModCount((VehicleMod)16) - 1, true);
			veh.SetMod((VehicleMod)24, rdWheel.Next(-1, veh.GetModCount((VehicleMod)24) - 1), rdWheel.Next(0, 2) > 0);
			veh.SetMod((VehicleMod)12, veh.GetModCount((VehicleMod)12) - 1, true);
			veh.SetMod((VehicleMod)34, veh.GetModCount((VehicleMod)34) - 1, true);
			veh.SetMod((VehicleMod)29, veh.GetModCount((VehicleMod)29) - 1, true);
			veh.SetMod((VehicleMod)30, veh.GetModCount((VehicleMod)30) - 1, true);
			veh.SetMod((VehicleMod)31, veh.GetModCount((VehicleMod)31) - 1, true);
			veh.SetMod((VehicleMod)11, veh.GetModCount((VehicleMod)11) - 1, true);
			veh.SetMod((VehicleMod)39, veh.GetModCount((VehicleMod)39) - 1, true);
			veh.SetMod((VehicleMod)4, veh.GetModCount((VehicleMod)4) - 1, true);
			veh.SetMod((VehicleMod)8, veh.GetModCount((VehicleMod)8) - 1, true);
			veh.SetMod((VehicleMod)5, veh.GetModCount((VehicleMod)5) - 1, true);
			veh.SetMod((VehicleMod)1, veh.GetModCount((VehicleMod)1) - 1, true);
			veh.SetMod((VehicleMod)23, rdWheel.Next(-1, veh.GetModCount((VehicleMod)23) - 1), rdWheel.Next(0, 2) > 0);
			veh.SetMod((VehicleMod)6, veh.GetModCount((VehicleMod)6) - 1, true);
			veh.SetMod((VehicleMod)7, veh.GetModCount((VehicleMod)7) - 1, true);
			veh.SetMod((VehicleMod)14, veh.GetModCount((VehicleMod)14) - 1, true);
			veh.SetMod((VehicleMod)38, veh.GetModCount((VehicleMod)38) - 1, true);
			veh.SetMod((VehicleMod)48, veh.GetModCount((VehicleMod)48) - 1, true);
			veh.SetMod((VehicleMod)28, veh.GetModCount((VehicleMod)28) - 1, true);
			veh.SetMod((VehicleMod)35, veh.GetModCount((VehicleMod)35) - 1, true);
			veh.SetMod((VehicleMod)25, veh.GetModCount((VehicleMod)25) - 1, true);
			veh.SetMod((VehicleMod)2, veh.GetModCount((VehicleMod)2) - 1, true);
			veh.SetMod((VehicleMod)9, veh.GetModCount((VehicleMod)9) - 1, true);
			veh.SetMod((VehicleMod)10, veh.GetModCount((VehicleMod)10) - 1, true);
			veh.SetMod((VehicleMod)32, veh.GetModCount((VehicleMod)32) - 1, true);
			veh.SetMod((VehicleMod)3, veh.GetModCount((VehicleMod)3) - 1, true);
			veh.SetMod((VehicleMod)36, veh.GetModCount((VehicleMod)36) - 1, true);
			veh.SetMod((VehicleMod)0, veh.GetModCount((VehicleMod)0) - 1, true);
			veh.SetMod((VehicleMod)33, veh.GetModCount((VehicleMod)33) - 1, true);
			veh.SetMod((VehicleMod)41, veh.GetModCount((VehicleMod)41) - 1, true);
			veh.SetMod((VehicleMod)15, veh.GetModCount((VehicleMod)15) - 1, true);
			veh.SetMod((VehicleMod)45, veh.GetModCount((VehicleMod)45) - 1, true);
			veh.SetMod((VehicleMod)13, veh.GetModCount((VehicleMod)13) - 1, true);
			veh.SetMod((VehicleMod)44, veh.GetModCount((VehicleMod)44) - 1, true);
			veh.SetMod((VehicleMod)27, veh.GetModCount((VehicleMod)27) - 1, true);
			veh.SetMod((VehicleMod)37, veh.GetModCount((VehicleMod)37) - 1, true);
			veh.SetMod((VehicleMod)26, veh.GetModCount((VehicleMod)26) - 1, true);
			veh.SetMod((VehicleMod)46, veh.GetModCount((VehicleMod)46) - 1, true);
			veh.ToggleMod((VehicleToggleMod)21, rdWheel.Next(0, 2) > 0);
			veh.ToggleMod((VehicleToggleMod)17, rdWheel.Next(0, 2) > 0);
			veh.ToggleMod((VehicleToggleMod)19, rdWheel.Next(0, 2) > 0);
			veh.SetNeonLightsOn((VehicleNeonLight)3, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)2, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)0, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)1, enableNeon);
			rdColor = new Random();
			veh.NeonLightsColor = Color.FromArgb(rdColor.Next(0, 255), rdColor.Next(0, 255), rdColor.Next(0, 255));
			veh.WindowTint = VehicleWindowTint.None;
			veh.XenonLightsColor((NewFunc.eXenonColor)rdColor.Next(0, 12));
			if (IsNitroModInstalled()) veh.SetBool(nitroModDecor, true);
		}

		public static void RandomlyUpgradeVehicle(this Vehicle veh)
		{
			veh.InstallModKit();
			rdMod = new Random();
			veh.SetMod((VehicleMod)43, rdMod.Next(-1, veh.GetModCount((VehicleMod)43) - 1), true);
			veh.SetMod((VehicleMod)40, rdMod.Next(-1, veh.GetModCount((VehicleMod)40) - 1), true);
			veh.SetMod((VehicleMod)42, rdMod.Next(-1, veh.GetModCount((VehicleMod)42) - 1), true);
			veh.SetMod((VehicleMod)16, rdMod.Next(-1, veh.GetModCount((VehicleMod)16) - 1), true);
			veh.SetMod((VehicleMod)24, rdMod.Next(-1, veh.GetModCount((VehicleMod)24) - 1), true);
			veh.SetMod((VehicleMod)12, rdMod.Next(-1, veh.GetModCount((VehicleMod)12) - 1), true);
			veh.SetMod((VehicleMod)34, rdMod.Next(-1, veh.GetModCount((VehicleMod)34) - 1), true);
			veh.SetMod((VehicleMod)29, rdMod.Next(-1, veh.GetModCount((VehicleMod)29) - 1), true);
			veh.SetMod((VehicleMod)30, rdMod.Next(-1, veh.GetModCount((VehicleMod)30) - 1), true);
			veh.SetMod((VehicleMod)31, rdMod.Next(-1, veh.GetModCount((VehicleMod)31) - 1), true);
			veh.SetMod((VehicleMod)11, rdMod.Next(-1, veh.GetModCount((VehicleMod)11) - 1), true);
			veh.SetMod((VehicleMod)39, rdMod.Next(-1, veh.GetModCount((VehicleMod)39) - 1), true);
			veh.SetMod((VehicleMod)4, rdMod.Next(-1, veh.GetModCount((VehicleMod)4) - 1), true);
			veh.SetMod((VehicleMod)8, rdMod.Next(-1, veh.GetModCount((VehicleMod)8) - 1), true);
			veh.SetMod((VehicleMod)5, rdMod.Next(-1, veh.GetModCount((VehicleMod)5) - 1), true);
			veh.SetMod((VehicleMod)1, rdMod.Next(-1, veh.GetModCount((VehicleMod)1) - 1), true);
			veh.SetMod((VehicleMod)23, rdMod.Next(-1, veh.GetModCount((VehicleMod)23) - 1), true);
			veh.SetMod((VehicleMod)6, rdMod.Next(-1, veh.GetModCount((VehicleMod)6) - 1), true);
			veh.SetMod((VehicleMod)7, rdMod.Next(-1, veh.GetModCount((VehicleMod)7) - 1), true);
			veh.SetMod((VehicleMod)14, rdMod.Next(-1, veh.GetModCount((VehicleMod)14) - 1), true);
			veh.SetMod((VehicleMod)38, rdMod.Next(-1, veh.GetModCount((VehicleMod)38) - 1), true);
			veh.SetMod((VehicleMod)48, rdMod.Next(-1, veh.GetModCount((VehicleMod)48) - 1), true);
			veh.SetMod((VehicleMod)28, rdMod.Next(-1, veh.GetModCount((VehicleMod)28) - 1), true);
			veh.SetMod((VehicleMod)35, rdMod.Next(-1, veh.GetModCount((VehicleMod)35) - 1), true);
			veh.SetMod((VehicleMod)25, rdMod.Next(-1, veh.GetModCount((VehicleMod)25) - 1), true);
			veh.SetMod((VehicleMod)2, rdMod.Next(-1, veh.GetModCount((VehicleMod)2) - 1), true);
			veh.SetMod((VehicleMod)9, rdMod.Next(-1, veh.GetModCount((VehicleMod)9) - 1), true);
			veh.SetMod((VehicleMod)10, rdMod.Next(-1, veh.GetModCount((VehicleMod)10) - 1), true);
			veh.SetMod((VehicleMod)32, rdMod.Next(-1, veh.GetModCount((VehicleMod)32) - 1), true);
			veh.SetMod((VehicleMod)3, rdMod.Next(-1, veh.GetModCount((VehicleMod)3) - 1), true);
			veh.SetMod((VehicleMod)36, rdMod.Next(-1, veh.GetModCount((VehicleMod)36) - 1), true);
			veh.SetMod((VehicleMod)0, rdMod.Next(-1, veh.GetModCount((VehicleMod)0) - 1), true);
			veh.SetMod((VehicleMod)33, rdMod.Next(-1, veh.GetModCount((VehicleMod)33) - 1), true);
			veh.SetMod((VehicleMod)41, rdMod.Next(-1, veh.GetModCount((VehicleMod)41) - 1), true);
			veh.SetMod((VehicleMod)15, rdMod.Next(-1, veh.GetModCount((VehicleMod)15) - 1), true);
			veh.SetMod((VehicleMod)45, rdMod.Next(-1, veh.GetModCount((VehicleMod)45) - 1), true);
			veh.SetMod((VehicleMod)13, rdMod.Next(-1, veh.GetModCount((VehicleMod)13) - 1), true);
			veh.SetMod((VehicleMod)44, rdMod.Next(-1, veh.GetModCount((VehicleMod)44) - 1), true);
			veh.SetMod((VehicleMod)27, rdMod.Next(-1, veh.GetModCount((VehicleMod)27) - 1), true);
			veh.SetMod((VehicleMod)37, rdMod.Next(-1, veh.GetModCount((VehicleMod)37) - 1), true);
			veh.SetMod((VehicleMod)26, rdMod.Next(-1, veh.GetModCount((VehicleMod)26) - 1), true);
			veh.SetMod((VehicleMod)46, rdMod.Next(-1, veh.GetModCount((VehicleMod)46) - 1), true);
			veh.ToggleMod((VehicleToggleMod)21, rdMod.Next(0, 2) > 0);
			veh.ToggleMod((VehicleToggleMod)17, rdMod.Next(0, 2) > 0);
			veh.ToggleMod((VehicleToggleMod)19, rdMod.Next(0, 2) > 0);
			veh.SetNeonLightsOn((VehicleNeonLight)3, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)2, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)0, enableNeon);
			veh.SetNeonLightsOn((VehicleNeonLight)1, enableNeon);
			rdColor = new Random();
			veh.NeonLightsColor = Color.FromArgb(rdColor.Next(0, 255), rdColor.Next(0, 255), rdColor.Next(0, 255));
			veh.WindowTint = VehicleWindowTint.None;
			veh.XenonLightsColor((NewFunc.eXenonColor)rdColor.Next(0, 12));
			if (IsNitroModInstalled()) veh.SetBool(nitroModDecor, rdMod.Next(0, 2) > 0);
		}

		public static void PaintVehicle(this Vehicle veh)
		{
			rdColor = new Random();
			veh.PrimaryColor = (VehicleColor)rdColor.Next(0, 160);
			veh.SecondaryColor = veh.PrimaryColor;
			rdMod = new Random();
			int chance = rdMod.Next(0, 100);
			if (chance >= 0 && chance <= upgradeChance) veh.SecondaryColor = (VehicleColor)rdColor.Next(0, 160);
			veh.PearlescentColor = (VehicleColor)rdColor.Next(0, 160);
			veh.DashboardColor = (VehicleColor)rdColor.Next(0, 160);
			veh.TrimColor = (VehicleColor)rdColor.Next(0, 160);
			veh.RimColor = (VehicleColor)rdColor.Next(0, 160);
		}

		public static void ForwardSpeed(this Vehicle veh, float value)
		{
			GTA.Native.Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, veh, value);
		}

		public enum eZone
		{
			Downtown,
			Vinewood,
			SouthLosSantos,
			PortOfSouthLosSantos,
			EastLosSantos,
			Vespucci,
			LosSantos,
			GrandSenoraDesert,
			SanChianskiMountainRange,
			BlaineCounty,
			FortZancudo
		}

		public static List<string> GetPlayerZoneVehicleList()
		{
			var pp = Game.Player.Character.Position;
			var zone = GTA.Native.Function.Call<string>(Hash.GET_NAME_OF_ZONE, pp.X, pp.Y, pp.Z);
			switch (zone)
			{
				case "PBOX":
				case "SKID":
				case "TEXTI":
				case "LEGSQU":
				case "DOWNT":
				{
					return vehicles.Downtown;
				}
				case "DTVINE":
				case "EAST_V":
				case "MIRR":
				case "HORS":
				case "WVINE":
				case "ALTA":
				case "HAWICK":
				case "VINE":
				case "RICHM":
				case "golf":
				case "ROCKF":
				case "CHIL":
				case "RGLEN":
				case "OBSERV":
				case "GALLI":
				{
					return vehicles.Vinewood;
				}
				case "DAVIS":
				case "STRAW":
				case "CHAMH":
				case "RANCHO":
				{
					return vehicles.SouthLosSantos;
				}
				case "BANNING":
				case "ELYSIAN":
				case "TERMINA":
				case "ZP_ORT":
				{
					return vehicles.PortOfSouthLosSantos;
				}
				case "LMESA":
				case "CYPRE":
				case "EBURO":
				case "MURRI":
				{
					return vehicles.EastLosSantos;
				}
				case "VESP":
				case "BEACH":
				case "VCANA":
				case "DELSOL":
				{
					return vehicles.Vespucci;
				}
				case "DELBE":
				case "DELPE":
				case "LOSPUER":
				case "STAD":
				case "KOREAT":
				case "AIRP":
				case "MORN":
				case "PBLUFF":
				case "BHAMCA":
				case "CHU":
				case "TONGVAH":
				case "TONGVAV":
				case "GREATC":
				case "TATAMO":
				case "LDAM":
				case "LACT":
				case "PALHIGH":
				case "NOOSE":
				case "MOVIE":
				case "SanAnd":
				{
					return vehicles.LosSantos;
				}
				case "DESRT":
				case "JAIL":
				case "RTRAK":
				{
					return vehicles.GrandSenoraDesert;
				}
				case "SANCHIA":
				case "WINDF":
				case "PALMPOW":
				case "HUMLAB":
				case "ZQ_UAR":
				{
					return vehicles.SanChianskiMountainRange;
				}
				case "PALETO":
				case "PALFOR":
				case "PALCOV":
				case "PROCOB":
				case "HARMO":
				case "SANDY":
				case "MTJOSE":
				case "ZANCUDO":
				case "SLAB":
				case "NCHU":
				case "CANNY":
				case "CCREAK":
				case "CALAFB":
				case "CMSW":
				case "ALAMO":
				case "GRAPES":
				case "MTGORDO":
				case "ELGORL":
				case "BRADP":
				case "MTCHIL":
				case "GALFISH":
				case "BRADT":
				case "LAGO":
				{
					return vehicles.BlaineCounty;
				}
				case "ARMYB":
				{
					return vehicles.FortZancudo;
				}
	
				default:
				{
					return new List<string>();
				}
			}
		}

		public static int GetCurrentWaitTime()
		{
			switch (World.CurrentDayTime.Hours)
			{
				case var @case when 0 <= @case && @case <= 5:
				{
					return waitTime.Midnight;
				}
				case var case1 when 6 <= case1 && case1 <= 11:
				{
					return waitTime.Morning;
				}
				case var case2 when 12 <= case2 && case2 <= 17:
				{
					return waitTime.Afternoon;
				}
				case var case3 when 18 <= case3 && case3 <= 21:
				{
					return waitTime.Evening;
				}
	
				default:
				{
					return waitTime.Night;
				}
			}
		}

		public static bool IsOnRoad(this Vehicle veh)
		{
			return GTA.Native.Function.Call<bool>(Hash.IS_POINT_ON_ROAD, veh.Position.X, veh.Position.Y, veh.Position.Z, veh);
		}

		public static Tuple<int, int> GetVehicleNodeProperties(this Vector3 pos)
		{
			OutputArgument outD = new OutputArgument(), outF = new OutputArgument();
			GTA.Native.Function.Call<bool>(Hash.GET_VEHICLE_NODE_PROPERTIES, pos.X, pos.Y, pos.Z, outD, outF);
			return new Tuple<int, int>(outD.GetResult<int>(), outF.GetResult<int>());
		}

		public static Point GetSafeZoneSize()
		{
			float t = GTA.Native.Function.Call<float>(Hash.GET_SAFE_ZONE_SIZE);
			double g = Math.Round((double)t, 2);
			g = g * 100f - 90f;
			g = 10f - g;

			var sw = Game.ScreenResolution.Width;
			var sh = Game.ScreenResolution.Height;
	
			float r = sw / sh;
			float wmp = r * 5.4f;
			return new Point((int)Math.Round(Math.Round(g * (double)wmp)), (int)Math.Round(Math.Round(g * 5.4f)));
		}

		public static List<Vector5> GetParkingSpotByZone(this Vector3 pp)
		{
			var zone = GTA.Native.Function.Call<string>(Hash.GET_NAME_OF_ZONE, pp.X, pp.Y, pp.Z);
			switch (zone)
			{
				case "DOWNT":
				case "VINE":
				{
					return CarGens.DOWNT;
				}
				case "GALLI":
				case "CHIL":
				{
					return CarGens.CHIL;
				}
				case "DESRT":
				case "GREATC":
				{
					return CarGens.DESRT;
				}
				case "CMSW":
				case "PALCOV":
				{
					return CarGens.CMSW;
				}
				case "PBOX":
				{
					return CarGens.PBOX;
				}
				case "SKID":
				{
					return CarGens.SKID;
				}
				case "TEXTI":
				{
					return CarGens.TEXTI;
				}
				case "LEGSQU":
				{
					return CarGens.LEGSQU;
				}
				case "CANNY":
				{
					return CarGens.CANNY;
				}
				case "DTVINE":
				{
					return CarGens.DTVINE;
				}
				case "EAST_V":
				{
					return CarGens.EAST_V;
				}
				case "MIRR":
				{
					return CarGens.MIRR;
				}
				case "WVINE":
				{
					return CarGens.WVINE;
				}
				case "ALTA":
				{
					return CarGens.ALTA;
				}
				case "HAWICK":
				{
					return CarGens.HAWICK;
				}
				case "RICHM":
				{
					return CarGens.RICHM;
				}
				case "golf":
				{
					return CarGens.golf;
				}
				case "ROCKF":
				{
					return CarGens.ROCKF;
				}
				case "CCREAK":
				{
					return CarGens.CCREAK;
				}
				case "RGLEN":
				{
					return CarGens.RGLEN;
				}
				case "OBSERV":
				{
					return CarGens.OBSERV;
				}
				case "DAVIS":
				{
					return CarGens.DAVIS;
				}
				case "STRAW":
				{
					return CarGens.STRAW;
				}
				case "CHAMH":
				{
					return CarGens.CHAMH;
				}
				case "RANCHO":
				{
					return CarGens.RANCHO;
				}
				case "BANNING":
				{
					return CarGens.BANNING;
				}
				case "ELYSIAN":
				{
					return CarGens.ELYSIAN;
				}
				case "TERMINA":
				{
					return CarGens.TERMINA;
				}
				case "ZP_ORT":
				{
					return CarGens.ZP_ORT;
				}
				case "LMESA":
				{
					return CarGens.LMESA;
				}
				case "CYPRE":
				{
					return CarGens.CYPRE;
				}
				case "EBURO":
				{
					return CarGens.EBURO;
				}
				case "MURRI":
				{
					return CarGens.MURRI;
				}
				case "VESP":
				{
					return CarGens.VESP;
				}
				case "BEACH":
				{
					return CarGens.BEACH;
				}
				case "VCANA":
				{
					return CarGens.VCANA;
				}
				case "DELSOL":
				{
					return CarGens.DELSOL;
				}
				case "DELBE":
				{
					return CarGens.DELBE;
				}
				case "DELPE":
				{
					return CarGens.DELPE;
				}
				case "LOSPUER":
				{
					return CarGens.LOSPUER;
				}
				case "STAD":
				{
					return CarGens.STAD;
				}
				case "KOREAT":
				{
					return CarGens.KOREAT;
				}
				case "AIRP":
				{
					return CarGens.AIRP;
				}
				case "MORN":
				{
					return CarGens.MORN;
				}
				case "PBLUFF":
				{
					return CarGens.PBLUFF;
				}
				case "BHAMCA":
				{
					return CarGens.BHAMCA;
				}
				case "CHU":
				{
					return CarGens.CHU;
				}
				case "TONGVAH":
				{
					return CarGens.TONGVAH;
				}
				case "TONGVAV":
				{
					return CarGens.TONGVAV;
				}
				case "TATAMO":
				{
					return CarGens.TATAMO;
				}
				case "PALHIGH":
				{
					return CarGens.PALHIGH;
				}
				case "NOOSE":
				{
					return CarGens.NOOSE;
				}
				case "MOVIE":
				{
					return CarGens.MOVIE;
				}
				case "SanAnd":
				{
					return CarGens.SanAnd;
				}
				case "ALAMO":
				{
					return CarGens.ALAMO;
				}
				case "JAIL":
				{
					return CarGens.JAIL;
				}
				case "RTRAK":
				{
					return CarGens.RTRAK;
				}
				case "SANCHIA":
				{
					return CarGens.SANCHIA;
				}
				case "WINDF":
				{
					return CarGens.WINDF;
				}
				case "PALMPOW":
				{
					return CarGens.PALMPOW;
				}
				case "HUMLAB":
				{
					return CarGens.HUMLAB;
				}
				case "ZQ_UAR":
				{
					return CarGens.ZQ_UAR;
				}
				case "PALETO":
				{
					return CarGens.PALETO;
				}
				case "PALFOR":
				{
					return CarGens.PALFOR;
				}
				case "PROCOB":
				{
					return CarGens.PROCOB;
				}
				case "HARMO":
				{
					return CarGens.HARMO;
				}
				case "SANDY":
				{
					return CarGens.SANDY;
				}
				case "ZANCUDO":
				{
					return CarGens.ZANCUDO;
				}
				case "SLAB":
				{
					return CarGens.SLAB;
				}
				case "NCHU":
				{
					return CarGens.NCHU;
				}
				case "GRAPES":
				{
					return CarGens.GRAPES;
				}
				case "MTGORDO":
				{
					return CarGens.MTGORDO;
				}
				case "MTCHIL":
				{
					return CarGens.MTCHIL;
				}
				case "GALFISH":
				{
					return CarGens.GALFISH;
				}
				case "LAGO":
				{
					return CarGens.LAGO;
				}
				case "ARMYB":
				{
					return CarGens.ARMYB;
				}
				case "BURTON":
				{
					return CarGens.BURTON;
				}
	
				default:
				{
					return new List<Vector5>();
				}
			}
		}

		public static Vector5 GetNearestParkingSpot(this Vector3 pos)
		{
			var result = pos.GetParkingSpotByZone().OrderBy(x => Math.Abs(x.Vector3.DistanceToSquared(pos)));
			if (result.Count() != 0) return result.FirstOrDefault();
			else return Vector5.Zero();
		}
	
		public static bool IsPositionOccupied(this Vector3 pos, float range)
		{
			return GTA.Native.Function.Call<bool>(Hash.IS_POSITION_OCCUPIED, pos.X, pos.Y, pos.Z, range, false, true, false, false, false, 0, false);
		}

		public static string GetPlayerZone()
		{
			Vector3 pos = Game.Player.Character.Position;
			return GTA.Native.Function.Call<string>(Hash.GET_NAME_OF_ZONE, pos.X, pos.Y, pos.Z);
		}

		public static void ClearVehicles(this Vehicle[] spawnVehicles)
		{
			for (int v = 0, loopTo = spawnVehicles.Count() - 1; v <= loopTo; v++)
			{
				var veh = spawnVehicles[v];
				if (IsVehicleSpawnedByMod(veh) && veh.Position.DistanceTo(Game.Player.Character.Position) > spawnDistance * 4f)
				{
					for (int p = 0, loopTo1 = veh.PassengerCount - 1; p <= loopTo1; p++)
					{
						veh.Passengers[p].Delete();
					}
					if (showBlip) veh.CurrentBlip.Remove();
					if (notify) UI.Notify($"~r~{(veh.FriendlyName == "NULL" ? veh.DisplayName : veh.FriendlyName)}~w~ at {World.GetStreetName(veh.Position)} was despawned.");
					veh.Delete();
				}
			}
		}

		public static void ClearPeds(this Ped[] spawnPeds)
		{
			for (int p = 0, loopTo = spawnPeds.Count() - 1; p <= loopTo; p++)
			{
				var ped = spawnPeds[p];
				if (IsPedSpawnByMod(ped) && ped.Position.DistanceTo(Game.Player.Character.Position) > spawnDistance * 4f)
				{
					if (notify) UI.Notify($"A ped at {World.GetStreetName(ped.Position)} was despawned.");
					ped.Delete();
				}
			}
		}

		public static int HowManyVehiclesSpawnedByModOnWorldRightNow()
		{
			return World.GetAllVehicles().Where(v => IsVehicleSpawnedByMod(v)).Count();
		}

		public static bool IsNitroModInstalled()
		{
			return Decor.Registered(nitroModDecor, Decor.eDecorType.Bool);
		}
	}
}