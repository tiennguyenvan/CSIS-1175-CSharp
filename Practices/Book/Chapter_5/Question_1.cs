using static System.Console;
namespace Book.Chapter_5
{
	class RomanNumber
    {
        // fields
        public int number = 0;

        // default
        public RomanNumber() { }

        // param
        public RomanNumber(
            int number
        )
        {
            

            this.number = number;
        }

        public string RomanNumberFormat()
        {
            return number switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                10 => "X",
                _ => "",
            };
        }
    }
    // main class
	public class Question_1
	{
        public static string EnterString(string label)
        {
            Write($"Enter {label}: ");
            return ReadLine();
        }
        public static int EnterInt(string label)
        {
            if (int.TryParse(EnterString(label), out int value))
            {
                return value;
            }
            return 0;
        }
        // represent Main
        public static void Solution()
		{
            int number = EnterInt("Decimal Number");

            if (number < 1 || number > 10)
            {
                WriteLine($"The Entered Number {number} is out of range (1, 10)");
                return;
            }
            RomanNumber romainNumber = new(number: number);

            WriteLine($"Roman Format: {romainNumber.RomanNumberFormat()}");
		}

       
    }
}

