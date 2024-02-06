using System;
using static System.Console;

namespace Book.Chapter_3 {
    class Question_6 {
        const double CommissionRate = 0.07;
        const double FederalTaxRate = 0.18;
        const double RetiremetnRate = 0.1;
        const double SocialSecurityRate = 0.06;

        public static void Solution() {
            double meters = Input();
            Calculation(meters, out double feet, out double inches);
            Display(meters, feet, inches);
        }
        static double Input()
        {
            Write("Input Number of Meters: ");
            return double.Parse(ReadLine() ?? "0");            
        }
        static void Calculation(double meters, out double feet, out double inches)
        {
            feet = 3.28 * meters;
            inches = 39.3701 * meters;
        }
        static void Display(double meters, double feet, double inches)
        {
            WriteLine("-------------------------------------");            
            WriteLine("{0:F2} meters = {1:F2} feet or {2:F2} inches", meters, feet, inches);            
        }
    }
}