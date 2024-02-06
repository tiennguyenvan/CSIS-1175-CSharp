using System;
using static System.Console;

namespace Book.Chapter_3 {
    
    
    class Question_8 {
        const int BarPerCase = 12;
        const double CaseLocalPrice = 5;
        const double CommisionRate = .1;

        public static void Solution() {
            Input(out int cases, out double barPrice);
            Compute(cases, barPrice, out double revenue, out double cost, out double earning);
            Display(cases, barPrice, revenue, cost, earning);
        }

        static void Input(out int cases, out double barPrice)
        {
            Write("Input number cases sold: ");
            cases = int.Parse(ReadLine());
            Write("Input price per bar $");
            barPrice = double.Parse(ReadLine());
        }
        static void Compute(int cases, double barPrice, out double revenue, out double cost, out double earning)
        {
            revenue = cases * barPrice * BarPerCase;
            cost = cases * CaseLocalPrice;
            earning = (revenue - cost) * CommisionRate;
        }

        static void Display(int cases, double barPrice, double revenue, double cost, double earning)
        {
            WriteLine("--------------------------------------");
            WriteLine("REVENUE:");
            //WriteLine("Sold: {0}", cases);
            //WriteLine("Each cases has: {0} bars", BarPerCase);
            //WriteLine("Price of each bar: {0:C2}", barPrice);
            WriteLine(
                "{0} cases * {1} bars each * {2:C2} per bar = {3:C2}",
                cases, BarPerCase, barPrice, revenue
            );
            WriteLine("--------------------------------------");
            WriteLine("EARNED:");
            WriteLine(
                "({0:C2} revenue - ({1} cases *  {2:C2} per case)) * {3:P1} commission rate = {4:C2}",
                revenue, cases, CaseLocalPrice, CommisionRate, earning
            );           
        }
    }
}