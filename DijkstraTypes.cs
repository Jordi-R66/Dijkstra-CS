namespace DijkstraCS {
	namespace Types
	{
		public enum TypeLien
		{
			LIEN_UNI = 0,
			LEIN_BI = 2,
			ERR = 3
		}

		public class Sommet
		{
			private Int64 id;
			readonly private String name;

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