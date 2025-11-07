using System;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Shape rectangle1 = new Rectangle(5, 3, 5, 2, 1, ConsoleColor.Green);
			rectangle1.info();
		}
	}
}