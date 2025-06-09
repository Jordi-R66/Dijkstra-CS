using DijkstraCS.Types;

namespace DijkstraCS {
	internal class Program {
		static void Main()
		{
			Sommet s = new(0, "Test1", 0.1, 0.2, 0.3);

			Sommet voisin = new Sommet(1, "V1", 1.0, 1.0, 1.0);

			s.addNeighbour(voisin);

			Console.WriteLine(s.GetsTo);
		}
	}
}