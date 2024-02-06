using System;
using static System.Console;

namespace Book.Chapter_3 {
    class Question_7 {
        const double Tip15 = 0.15;
        const double Tip20 = 0.2;
        public static void Solution() {
            double bill = InputBill();
            double taxed = bill + bill * 0.09;
            Compute(taxed, out double _15, out double _20, out double f15, out double f20);            
            DisplayFinal(taxed, _15, _20, f15, f20);
        }
        static double InputBill()
        {
            Write("Input Bill Charge $");
            return double.Parse(ReadLine() ?? "0");
        }
        static void Compute(double taxed, out double _15, out double _20, out double f15, out double f20)
        {
            _15 = taxed * Tip15;
            _20 = taxed * Tip20;
            f15 = taxed - _15;
            f20 = taxed - _20;
        }

        static void DisplayFinal(double taxed, double _15, double _20, double f15, double f20) 
        {
            WriteLine("---------------------------------");
            WriteLine("After taxed: {0:C2}", taxed);
            WriteLine("---------------------------------");
            WriteLine("Total charge after 15% tip ({0:C2}): {1:C2}", _15, f15);
            WriteLine("Total charge after 20% tip ({0:C2}): {1:C2}", _20, f20);

        }
    }
}