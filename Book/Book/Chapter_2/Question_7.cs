using System;
using static System.Console;

namespace Chapter_2 {
    class Question_7 {
        const double Tip15 = 0.15;
        const double Tip20 = 0.2;
        public static void Solution() {
            double bill = InputBill();
            Compute(bill, out double _15, out double _20);
            int option = InputOption(_15, _20);
            DisplayFinal(bill, _15, _20, option);
        }
        static double InputBill()
        {
            Write("Input Total Bill Charge $");
            return double.Parse(ReadLine() ?? "0");
        }
        static void Compute(double bill, out double _15, out double _20)
        {
            _15 = bill * Tip15;
            _20 = bill * Tip20;
        }

        static int InputOption(double _15, double _20)
        {
            WriteLine("-------------------------------------");
            WriteLine("TIP:");
            WriteLine("Option #1 ({0:P0}): {1:C2}", Tip15, _15);
            WriteLine("Option #2 ({0:P0}): {1:C2}", Tip20, _20);            
            Write("Input 1 or 2 to select the tip: ");
            return int.Parse(ReadLine() ?? "0");
        }
        static void DisplayFinal(double bill, double _15, double _20, int option) 
        {
            double final = bill - (option == 1 ? _15 : _20);
            WriteLine("-------------------------------------");
            WriteLine("FINAL CHARGE: {0:C2}", final);            
        }
    }
}