namespace DijkstraCS {
	namespace Types
	{
		public enum TypeLien
		{
			LIEN_UNI = 0,
			LEIN_BI = 2,
			ERR = 3
		}

		public readonly struct Coords
		{
			public readonly double x, y, z;

			public Coords(double x, double y, double z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public double getNorm()
			{
				return Math.Sqrt(x * x + y * y + z * z);
			}

			public static Coords operator -(Coords a, Coords b) => new Coords(b.x - a.x, b.y - a.y, b.z - a.z);
		}

		public class Sommet
		{
			private Int64 id;
			private String name;

			private Double x, y, z;

			public Sommet(Int64 id, String name, Double x, Double y, Double z)
			{
				this.id = id;
				this.name = name;

				this.x = x;
				this.y = y;
				this.z = z;
			}
		}
	}
}