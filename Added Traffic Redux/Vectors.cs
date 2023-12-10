using System;
using GTA.Math;

namespace Added_Traffic_Redux
{
	public static class VectorMath
	{
		// Modified from "https://github.com/dexyfex/CodeWalker/blob/master/CodeWalker.Core/GameFiles/FileTypes/YmapFile.cs#L3219"
		public static Vector2 GetOrientation(this Vector3 euler)
		{
			Quaternion ori = Quaternion.Euler(euler);

			// "2.6" seems to be one of the most common car generator "perpendicularLength" values from my findings in CodeWalker
			float len = Math.Max(2.6f * 1.5f, 5.0f);
			Vector3 v = new Vector3(len, 0f, 0f);
			Vector3 t = ori.QuatMulVec3(v);

			// Return negative pitch and positive yaw
			return new Vector2(-t.Y, t.X);
		}

		// From "https://github.com/dexyfex/CodeWalker/blob/master/CodeWalker.Core/Utils/Quaternions.cs#L15"
		public static Vector3 QuatMulVec3(this Quaternion a, Vector3 b)
		{
			float axx = a.X * 2.0f;
			float ayy = a.Y * 2.0f;
			float azz = a.Z * 2.0f;
			float awxx = a.W * axx;
			float awyy = a.W * ayy;
			float awzz = a.W * azz;
			float axxx = a.X * axx;
			float axyy = a.X * ayy;
			float axzz = a.X * azz;
			float ayyy = a.Y * ayy;
			float ayzz = a.Y * azz;
			float azzz = a.Z * azz;
			return new Vector3(((b.X * ((1.0f - ayyy) - azzz)) + (b.Y * (axyy - awzz))) + (b.Z * (axzz + awyy)),
							((b.X * (axyy + awzz)) + (b.Y * ((1.0f - axxx) - azzz))) + (b.Z * (ayzz - awxx)),
							((b.X * (axzz - awyy)) + (b.Y * (ayzz + awxx))) + (b.Z * ((1.0f - axxx) - ayyy)));
		}
	}

	public class Vector4
	{
		// Entity position
		public Vector3 Vector3;
		// A Vector5's Vector2 converted to a heading using ToHeading()
		public float floatVal;

		public Vector4(Vector3 v3, float f)
		{
			Vector3 = v3;
			floatVal = f;
		}
	}

	public class Vector5
	{
		// Entity position
		public Vector3 Vector3;
		// Entity negative pitch and positive yaw from GetOrientation()
		public Vector2 Vector2;

		public Vector5(Vector3 v3, Vector2 v2)
		{
			Vector3 = v3;
			Vector2 = v2;
		}

		public static Vector5 Zero()
		{
			return new Vector5(Vector3.Zero, Vector2.Zero);
		}
	}
}