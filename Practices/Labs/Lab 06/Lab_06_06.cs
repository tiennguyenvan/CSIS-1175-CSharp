using static System.Console;

namespace Labs.Lab_06
{
	public class Lab_06_06
	{
		public static void Solution()
		{
			// a
			WriteLine("a)");
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 7; j++) Write("* ");
          		WriteLine();
			}

			// b
			WriteLine("\nb)");
			const int max = 7, half = max / 2;
			int space = half;
			int star = 1;
			for (int i = 0; i < max; i++)
			{
				for (int j = 0; j < space; j++) Write("  ");
				for (int j = 0; j < star; j++)	Write("* ");
				if (i < half) { space--; star += 2; }
				else { space++; star -= 2; }

                WriteLine();
			}

			// c
			WriteLine("\nc)");
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j <= i; j++) Write("* ");
				WriteLine();
			}

		}
	}
}

