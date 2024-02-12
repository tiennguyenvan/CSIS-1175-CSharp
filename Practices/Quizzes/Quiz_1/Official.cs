using static System.Console;
namespace Quizzes.Quiz_1
{
	public class CalculationCost
	{
		const double HOUR_RATE = 35;
		public static void Input(ref string jobDescription, ref double materialCost, ref int hourOfWork)
		{
			WriteLine("The introduction here");
			Write("Enter Job Description: ");
			jobDescription = ReadLine();
			Write("Enter Material Cost");
			materialCost = double.Parse(ReadLine());
			Write("\nEnter Hour Number: ");
			hourOfWork = int.Parse(ReadLine());
		}
		public static double Calculation(double materialCost, double hourOfWork)
		{
			return materialCost + (hourOfWork * HOUR_RATE);
		}
		public static void Display(double cost)
		{
			WriteLine("The cost is {0:C2}", cost);
		}
		
		public static void Solution()
		{
			string jobDescription = "";
			double materialCost = 0;
			int hourOfWork = 0;
			Input(ref jobDescription, ref materialCost, ref hourOfWork);
			double cost = Calculation(materialCost, hourOfWork);
			Display(cost);

        }
	}
}

