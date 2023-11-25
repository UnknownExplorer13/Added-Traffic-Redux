using System.Linq;
using GTA;
using GTA.Math;
using GTA.Native;

namespace Added_Traffic_Redux
{
	internal static class UselessHelper
	{
		public static bool IsVehicleSwapEnabled()
		{
			return Helper.vehicleSwaps.Count() == 0;
		}

		public static VehicleClass GetVehicleClassFromName(this Model model)
		{
			return GTA.Native.Function.Call<VehicleClass>(Hash.GET_VEHICLE_CLASS_FROM_NAME, model.GetHashCode());
		}

		public static Helper.eZone GetPlayerZone2()
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
					return Helper.eZone.Downtown;
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
				case "GOLF":
				case "ROCKF":
				case "CHIL":
				case "RGLEN":
				{
					return Helper.eZone.Vinewood;
				}
				case "DAVIS":
				case "STRAW":
				case "CHAMH":
				case "RANCHO":
				{
					return Helper.eZone.SouthLosSantos;
				}
				case "BANNING":
				case "ELYSIAN":
				case "TERMINA":
				case "ZP_ORT":
				{
					return Helper.eZone.PortOfSouthLosSantos;
				}
				case "LMESA":
				case "CYPRE":
				case "EBURO":
				case "MURRI":
				{
					return Helper.eZone.EastLosSantos;
				}
				case "VESP":
				case "BEACH":
				case "VCANA":
				case "DELSOL":
				{
					return Helper.eZone.Vespucci;
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
				{
					return Helper.eZone.LosSantos;
				}
				case "DESRT":
				case "JAIL":
				case "RTRAK":
				{
					return Helper.eZone.GrandSenoraDesert;
				}
				case "SANCHIA":
				case "WINDF":
				case "PALMPOW":
				case "HUMLAB":
				case "ZQ_UAR":
				{
					return Helper.eZone.SanChianskiMountainRange;
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
				case "LAGO":
				case "ARMYB":
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
				{
					return Helper.eZone.BlaineCounty;
				}

				default:
				{
					return Helper.eZone.LosSantos;
				}
			}
		}

		public static Vector4 GetRoadSidePointWithHeading(this Vector3 pos)
		{
			OutputArgument outV = new OutputArgument(), outH = new OutputArgument();
			// GTA.Native.Function.Call<bool>(&HA0F8A7517A273C05UL, pos.X, pos.Y, pos.Z, outH, outV);
			return new Vector4(outV.GetResult<Vector3>(), outH.GetResult<float>());
		}

		public static Vector3 GetPointOnRoadSide(this Vector3 pos)
		{
			var output = new OutputArgument();
			// GTA.Native.Function.Call<bool>(&H16F46FB18C8009E4, pos.X, pos.Y, pos.Z, -1, output);
			return output.GetResult<Vector3>();
		}

		public static Vector4 GetCorrectRoadCoords(this Vector3 coords, eNodeType roadtype)
		{
			Vector3 closestVehicleNodeCoords = Vector3.Zero;
			float roadHeading = 0f;
			OutputArgument tempCoords = new OutputArgument(), tempRoadHeading = new OutputArgument();

			GTA.Native.Function.Call<Vector3>(Hash.GET_CLOSEST_VEHICLE_NODE_WITH_HEADING, coords.X, coords.Y, coords.Z, tempCoords, tempRoadHeading, (int)roadtype, 3.0f, 0);
			closestVehicleNodeCoords = tempCoords.GetResult<Vector3>();
			roadHeading = tempRoadHeading.GetResult<float>();
			return new Vector4(closestVehicleNodeCoords, roadHeading);
		}

		public static Vector3 FindSpawnPointInDirection(this Vector3 pos)
		{
			var output = new OutputArgument();
			var rot = Game.Player.Character.Rotation;
			GTA.Native.Function.Call<bool>(Hash.FIND_SPAWN_POINT_IN_DIRECTION, pos.X, pos.Y, pos.Z, rot.X, rot.Y, rot.Z, Helper.spawnDistance, output);
			return output.GetResult<Vector3>();
		}

		public static Vector4 GetNextPositionOnStreetWithHeading(this Vector3 pos)
		{
			OutputArgument outV = new OutputArgument(), outH = new OutputArgument(), outU = new OutputArgument();
			GTA.Native.Function.Call<bool>(Hash.GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING, pos.X, pos.Y, pos.Z, 1, outV, outH, outU, 9, 3.0f, 2.5f);
			return new Vector4(outV.GetResult<Vector3>(), outH.GetResult<float>());
		}

		public static int GetClosestVehicleNodeID(this Vector3 pos)
		{
			return GTA.Native.Function.Call<int>(Hash.GET_NTH_CLOSEST_VEHICLE_NODE_ID, pos.X, pos.Y, pos.Z, 1, (int)Helper.roadType, 1077936128, 0f);
		}
	}
}