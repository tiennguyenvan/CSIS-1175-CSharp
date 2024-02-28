using static System.Console;

namespace Book.Chapter_5 {
    class Month
    {
        // members
        private int monthNumber = 1;

        // input
        public void Input()
        {
            Write("Input month number: ");
            if (!int.TryParse(ReadLine(), out int monthNumber))
            {
                WriteLine("Input value is not an integer!");
                return;
            }

            if (monthNumber < 1 || monthNumber > 12)
            {
                WriteLine("Input value is not in the range (1,12)");
                return;
            }
            this.monthNumber = monthNumber;
        }

        // comput
        public string Compute()
        {                        
            int daysInMonth = DateTime.DaysInMonth(1, monthNumber);
            string monthName = monthNumber switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid"
            };

            return $"Month {monthNumber} named {monthName} and has {daysInMonth} days";
        }
    }

    class Question_7 {
        public static void Solution()
        {
            Month month = new();
            month.Input();

            WriteLine(month.Compute());
        }
    }
}