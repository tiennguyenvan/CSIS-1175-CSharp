using static System.Console;
namespace Book.Chapter_4
{
	class Date
	{
        // fields
		private int year = DateTime.Now.Year;
		private int month = DateTime.Now.Month;
		private int day = DateTime.Now.Day;
        private string monthName = "";

        // properties
        public int Year {
            get { return year; }
            set { year = value > 0 ? value : year; }                
        }
        public int Month
        {
            get { return month; }
            set { month = value > 0 && value < 13 ? value : month; }
        }
        public int Day
        {
            get { return day; }
            set { day = value > 0 && value < 32 ? value : day; }
        }
        public string MonthName
        {
            get {
                int maxDay = DateTime.DaysInMonth(Year, Month);
                if (Day > maxDay)
                {
                    Day = maxDay;
                }
                monthName = new DateTime(Year, Month, Day).ToString("MMM");                
                return monthName;
            }
        }

        // parameterized constructor
        public Date(int year = 0, int month = 0, int day = 0)
		{
            Year = year; Month = month; Day = day;
        }

        // override ToString();
        public override string ToString()
        {
            return $"{MonthName} {Day}, {Year}";
        }
    }

    // main class
	public class Question_1
	{
        // represent Main
		public static void Solution()
		{
            Date date = new(
                year: Inp("year", DateTime.Now.Year),
                month: Inp("month", DateTime.Now.Month),
                day: Inp("day", DateTime.Now.Day)
            );
            WriteLine(date.ToString());
		}

        // handle inputing single value
        static int Inp(string label, int defaultValue)
        {
            label = $"Input {label} (↵ to Skip): ";
            Write(label);
            ForegroundColor = ConsoleColor.DarkGray;
            Write(defaultValue);
            SetCursorPosition(label.Length, CursorTop);
            ResetColor();
            return int.TryParse(ReadLine(), out int value) ? value : defaultValue;
        }        
    }
}

