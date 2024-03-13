using static System.Console;
namespace Book.Chapter_6
{	
    // main class
	public class Question_1
	{
        
        // represent Main
        public static void Solution()
		{
            int outRange = 0;
            int notNumeric = 0;
            int valid = 0;            
            Write("Input positive integers (Leave blank to exit): ");
            string input;
            while ((input = ReadLine()) != "")
            {                                
                if (!int.TryParse(input, out int val))
                {
                    Write("Not an integer. Again: ");
                    notNumeric++;
                    continue;
                }
                if (val < 1 || val >= 100)
                {
                    Write("Out of range [1,99]. Again: ");
                    outRange++;
                    continue;
                }
                Write("Perfect. Another: ");
                valid++;
            }

            WriteLine(
                "----------------------------------------------\n"
                +$"Number of non-numeric inputs: {notNumeric}\n"
                +$"Number of out-of-range inputs: {outRange}\n"
                +$"Number of valid inputs: {valid}\n"
            );
		}       
    }
}

