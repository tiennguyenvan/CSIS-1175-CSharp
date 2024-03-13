using static System.Console;

namespace Book.Chapter_6 {
   
    class Question_7 {
        public static void Solution()
        {
            int first;
            Write("First: ");
            while (!int.TryParse(ReadLine(), out first) || first < 2 || first > 8)
            {
                Write("Invalid. Again: ");
            }
            int last;
            Write("Last: ");
            while (!int.TryParse(ReadLine(), out last) ||
                last < 2 || last > 8 || last < first)
            {
                Write("Invalid. Again: ");
            }
            WriteLine("-----------------------------");
            Write(" n");
            for (int i = first; i <= last; i++) Write($"{i,12}");
            WriteLine("\n");

            for (int i = 1; i < 26; i++)
            {
                Write($"{i,2}");
                for (int j = first; j <= last; j++) Write($"{(j*i),12}");
                WriteLine();
            }

        }
    }
}