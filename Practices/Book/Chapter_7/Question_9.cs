
using System;
using static System.Console;

namespace Book.Chapter_7 {


    class Question_9 {
       
        public static void Solution()
        {
            string str;
            int num = 0, max = 0;
            int[] values = new int[100];
            WriteLine("Input values (Enter -99 to finish): ");
            while ((str = ReadLine()) != "-99")
            {                
                if (!int.TryParse(str, out int val) || val < 0 || val > 10)
                {
                    Write("Invalid. Again: ");
                    continue;
                }

                values[num++] = val;
                max = Math.Max(max, val);
            }
            if (num < 1)
            {
                WriteLine("Not enough number to create the graph. Enter to Exit");
                return;
            }


            // show the graph
            Write("|\n");            
            for (int i = max; i > 0; i--)
            {
                Write("|   ");
                for (int j = 0; j < num; j++) Write(values[j] >= i ? "█  " : "   ");                
                WriteLine();
            }
            string baseLine = new string('-', 3 * num + 6);
            WriteLine("+" + baseLine);
        }
    }
}