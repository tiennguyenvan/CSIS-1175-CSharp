using static System.Console;

namespace Book.Chapter_6{   
	class Question_3 {        

		public static void Solution() {
			// my Mac has no windows form
			int min = int.MaxValue, max = int.MinValue, odd = 0;
			for (int i = 0; i < 1000; i++)
			{
				Random random = new ();
				int rand = random.Next(0, 100000);
				min = Math.Min(min, rand);
				max = Math.Max(max, rand);
				odd += (rand % 2);
			}

			WriteLine(
				"Random Results:\n"
				+$"Min: {min}\n"
                + $"Max: {max}\n"
                + $"Odd: {odd}\n"
            );
		}		
	}
}