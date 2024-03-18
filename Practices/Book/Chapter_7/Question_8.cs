using static System.Console;

namespace Book.Chapter_7 {
   
	class Question_8 {

        
		public static void Solution()
		{
			int num = 0;
			double[] scores = new double[100];
			double sum = 0, min = double.MaxValue, max = double.MinValue;
			string score;
			WriteLine("Input scores (Enter -99 to finish): ");
			while ((score = ReadLine()) != "-99")
			{				
				if (!double.TryParse(score, out double val) || val < 0 || val > 10)
				{
					Write("Invalid. Again: ");
					continue;
				}

				scores[num++] = val;
				sum += val;
				max = Math.Max(max, val);
				min = Math.Min(min, val);
			}

			if (num < 2)
			{
				WriteLine("Number of scores are not enough to calculate. Enter to Exit!");
				return;
			}
            double average = 0;
            if (num > 2)
			{
                average = (sum - max - min) / (num - 2);
            }


			WriteLine($"Average: {average:F2}");
            WriteLine($"Max: {max:F2}");
            WriteLine($"Min: {min:F2}");
        }
	}
}