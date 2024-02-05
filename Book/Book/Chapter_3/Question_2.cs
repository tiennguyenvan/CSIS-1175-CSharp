using System;
using static System.Console;

namespace Chapter_3 {
    class Question_2
    {
        public static void Solution()
        {
            
            string[] info = new string[4] {
                Info("Name", "Douglas"),
                Info("Students", "4000"),
                Info("Location", "New West"),
                Info("Color", "Brow")
            };

            int length = 0;
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i].Length > length)
                {
                    length = info[i].Length;
                }
            }
            
            Separator(length + 4);
            for (int i = 0; i < info.Length; i++)
            {
                WriteLine("* {0,-"+length+"} *", info[i], length);
            }
            Separator(length + 4);
        }
        static void Separator(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Write("*");
            }
            WriteLine();
        }
        static string Info(string label, string value)
        {            
            return string.Format("{0}: {1}", label, value);
        }
        
    }
}