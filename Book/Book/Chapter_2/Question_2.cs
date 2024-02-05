using System;
using static System.Console;

namespace Chapter_2 {
    class Question_2 {
        public static void Solution() {
            double miles = Input();
            double feet, km;
            Convert(miles, out feet, out km);
            Display(miles, feet, km);
        }
        static double Input()
        {
            Write("Input number of Mile(s): ");
            return double.Parse(ReadLine());
        }
        static void Convert(double miles, out double feet, out double km)
        {
            feet = 5280 * miles;
            km = 1.60934 * miles;
        }
        static void Display(double miles, double feet, double km)
        {
            WriteLine("{0:F2} miles = {1:D} feet or {2:F2} km", miles, (int) feet, km);
        }
    }
}