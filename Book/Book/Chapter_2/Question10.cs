using System;
using static System.Console;

namespace Chapter_2 {
    class Question10 {
        public static void Solution() {
            Write("Input price per 100 grams $");
            double p100g = double.Parse(ReadLine());
            double p1p = p100g / (100 * 0.00220462);
            WriteLine("Price per 1 pound: {0:C2}", p1p);
        }
    }
}