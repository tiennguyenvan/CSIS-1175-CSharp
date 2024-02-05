using System;
using static System.Console;

namespace Chapter_3 {
    class Question_4 {
        
        public static void Solution() {
            int seconds = Input();
            int hours = NumHours(ref seconds);
            int minutes = NumMinutes(ref seconds);
            Display(hours, minutes, seconds);
        }
        static int Input()
        {
            Write("Input number of seconds: ");
            return int.Parse(ReadLine());
        }
        static int NumHours(ref int seconds)
        {
            int hours = seconds / 3600;
            seconds %= 3600;
            return hours;
        }
        static int NumMinutes(ref int seconds)
        {
            int minutes = seconds / 60;
            seconds %= 60;
            return minutes;
        }
   
        static void Display(int h, int m, int s)
        {
            Write("Equal to:");
            if (h != 0)
            {
                Write(" {0} hour{1}", h, h == 1 ? "" : "s");
            }
            if (m != 0)
            {
                Write(" {0} minute{1}", m, m == 1 ? "" : "s");
            }
            if (s != 0)
            {
                Write(" {0} second{1}", s, s == 1 ? "" : "s");
            }
        }
    }
}