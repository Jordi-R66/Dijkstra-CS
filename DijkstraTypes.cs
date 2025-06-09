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
			public override String ToString()
			{
				return $"({x}, {y}, {z})";
			}
		}

		public class Sommet
		{
			private readonly Int64 id;
			private readonly String name;

			private readonly Coords coords;

			private HashSet<Sommet> getsTo;

			public Int64 Id
			{
				get { return id; }
			}

			public String Name
			{
				get { return name; }
			}

			public Coords Coords
			{
				get { return coords; }
			}

			public Sommet(Int64 id, String name, Double x, Double y, Double z)
			{
				this.id = id;
				this.name = name;

				this.coords = new Coords(x, y, z);
				this.getsTo = new HashSet<Sommet>();
			}

			public void addNeighbour(Sommet s)
			{
				this.getsTo.Add(s);
			}

			public double getDistance(Sommet other)
			{
				Coords diff = coords - Coords;
				return diff.getNorm();
			}

			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			public override bool Equals(object? obj)
			{
				return ReferenceEquals(this, obj);
			}
		}
	}
}