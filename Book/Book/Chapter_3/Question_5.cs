using System;
using static System.Console;

namespace Chapter_3 {
    class Question_5 {
        public static void Solution() {
            double F = Input();
            double C = Convert(F);
            Display(F, C);
        }
        static double Input()
        {            
            Write("Input Farenheit degree: ");
            return double.Parse(ReadLine());
        }
        static double Convert(double F)
        {
            return ((double)5 / 9) * (F - 32);
        }
        static void Display(double F, double C)
        {
            WriteLine("{0:F2}°F = {1:F2}°C", F, C);            
        }
    }
}