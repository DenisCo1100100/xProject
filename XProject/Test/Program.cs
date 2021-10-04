using System;

namespace Test
{
	class Program
	{
		static void Main()
		{
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int c = Convert.ToInt32(Console.ReadLine());

			int x = a + b;
			int y = x + a * c;

			Console.WriteLine(y);
		}
	}
}
