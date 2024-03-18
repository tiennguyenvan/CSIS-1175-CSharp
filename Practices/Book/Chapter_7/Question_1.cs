using static System.Console;
namespace Book.Chapter_7
{	
    // main class
	public class Question_1
	{


        // represent Main
        public static void Solution()
        {
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            double[] rain = new double[12];
            double sum = 0;
            Write($"Input rainfall amount (mm) for 12 months\n");
            for (int i = 0; i < rain.Length; i++)
            {
                Write($"{month[i]}: ");
                while (!double.TryParse(ReadLine(), out rain[i])) {
                    Write("Invalid. Again: ");
                }
                sum += rain[i];
            }
            string separator = new string('-', 12 * 6);

            Write(
                 $"{separator}\n"
                + "Rainfall Report\n"
                +$"{separator}\n"
            );

            for (int i = 0; i < rain.Length; i++) Write($"{month[i],-6}");
            WriteLine();
            for (int i = 0; i < rain.Length; i++) Write($"{rain[i],-6}");
            WriteLine();
            Write(
                  $"{separator}\n"
                + $"Average Rainfall Amount: {(sum / 12):F0}\n"                
            );
        }       
    }
}

