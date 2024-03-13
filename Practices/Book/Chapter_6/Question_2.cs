using System;
using static System.Console;

namespace Book.Chapter_6 {
   
    class Question_2
    {
        public static void Solution()
        {
            Write("Input wholesale price: ");
            double price;
            while (!double.TryParse(ReadLine(), out price))
            {
                Write("Wrong number, please try again: ");
            }
            WriteLine("-----------------------------");
            WriteLine($"You can earn from: {price:C}");
            for (double i = 0.05; i < 0.11; i += 0.01)
            {
                WriteLine($"at {i:P0}: {(price * i):C}");
            }
        }        
    }
}