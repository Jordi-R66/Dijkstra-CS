using DijkstraCS.Types;

namespace DijkstraCS {
	internal class Program {
		static void Main()
		{
			Coords test = new(1.0, 2.0, 3.0);

			Console.WriteLine(test);
			Console.WriteLine(test.getNorm());
		}
	}
}