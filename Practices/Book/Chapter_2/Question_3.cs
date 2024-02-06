using System;
using static System.Console;
using System.Linq;

namespace Book.Chapter_2 {
    class Question_3 {
        public static void Solution() {
            int[] scores = Input();
            double average = Compute(scores);
            Display(scores, average);
        }
        static int[] Input(int numScores = 5)
        {
            int[] ret = new int[5];
            for (int i = 0; i < numScores; i++)
            {
                Write("Input score number {0}: ", i+1);
                ret[i] = int.Parse(ReadLine());
            }
            return ret;
        }
        static double Compute(int[] scores)
        {
            double sum = scores.Sum();
            return sum / scores.Length;
        }
        static void Display(int[] scores, double average)
        {
            WriteLine("({0}) / {1} = {2:F2}", string.Join(" + ", scores), scores.Length, average);
        }
    }
}