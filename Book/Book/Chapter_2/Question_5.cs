using System;
using static System.Console;

namespace Chapter_2 {
    class Question_5 {
        public static void Solution() {
            WriteLine("Open Collar Running Shirt");
            
            Input(out double price, out int markdown);
            double retail = Compute(price, markdown);
            Display(price, markdown, retail);
        }
        static void Input(out double price, out int markdown)
        {            
            Write("Input price: ");
            price = double.Parse(ReadLine() ?? "0");
            Write("Input markdown: ");
            markdown = int.Parse(ReadLine() ?? "15");
        }
        static double Compute(double price, int markdown)
        {
            return price - price * ((double) markdown / 100);
        }
        static void Display(double price, int markdown, double retail)
        {
            WriteLine("Shirt at price {0:C2} with {1}% off is {2:C2}", price, markdown, retail);
            
        }
    }
}