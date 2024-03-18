using System;
using static System.Console;

namespace Book.Chapter_7 {
   
    class Question_5 {
        public static void Solution() {
            int num;
            Write("Number of months you want to input: ");
            while (!int.TryParse(ReadLine(), out num)) Write("Invalid. Again: ");

            double[] sale = new double[num];
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                Write($"Sale amount of month {(i+1)}: ");
                while (!double.TryParse(ReadLine(), out sale[i])) Write("Invalid. Again: ");
                sum += sale[i];
            }

            string[] label = { "Sale Amount", "Percent" };
            string separator = new string('-', label[0].Length + label[1].Length + 3);
            WriteLine();
            WriteLine("Ion Realty Sales Corporation Report");
            WriteLine(separator);
            Write($"{label[0]} | {label[1]}\n");
            WriteLine(separator);
            for (int i = 0; i < num; i++)
            {
                WriteLine("{0," + label[0].Length +":C} | {1," + label[1].Length +":P1}", sale[i], sale[i] / sum);
            }
            WriteLine(separator);
            Write($"Total Sale: {sum:C}");



        }
    }
}