using System;
using static System.Console;
namespace Book.Chapter_2
{
	public class Question_1
	{
		public static void Solution()
		{
			double C = Input();
			double F = Convert(C);
			Output(C, F);
		}

		static double Input()
		{
			WriteLine("Temperature Conversion App");
			Write("Input Celsius value: ");
			return double.Parse(ReadLine());
		}
        // Fahrenheit (°F) = (Celsius (°C) * 9/5) + 32;
        static double Convert(double C)
		{
			return C * (double)9 / 5 + 32;
		}
		static void Output(double C, double F)
		{
			WriteLine("{0:F0}°C = {1:F1}°F", C, F);
		}
	}
}

