using System;
using static System.Console;

namespace Book.Chapter_2 {
    class Question_9 {
        public static void Solution() {
            Write("Number of cases sold: ");
            int sold = int.Parse(ReadLine());
            int earned = sold * 5;
            WriteLine("Earned ($1.5 * 100 - $100) * {0} * 10% = {1:C2}", sold, earned);
        }
        
    }
}