using GTA.Math;

namespace Added_Traffic_Redux
{
	public class Vector4
	{
		public Vector3 Vector3;
		public float floatVal;

		public Vector4(Vector3 v3, float f)
		{
			Vector3 = v3;
			floatVal = f;
		}
	}

	public class Vector5
	{
		public Vector3 Vector3;
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