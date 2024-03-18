using System;
using static System.Console;

namespace Book.Chapter_7 {
   
    class Question_2
    {
        public static void Solution()
        {
            
            int num;
            Write("How many names you want to input? ");
            while (!int.TryParse(ReadLine(), out num)) Write("Invalid. Again: ");

            string[] name = new string[num];
            Write("Input names: \n");
            for (int i = 0; i < name.Length; i++)
            {
                Write($"Name {i + 1}: ");
                name[i] = ReadLine();                
            }

            Array.Sort(name);
            Write("---------------------------------\n");
            Write("Name after sorting: \n");
            Write("---------------------------------\n");
            foreach (string n in name) WriteLine(n);
            
        }        
    }
}