
using static System.Console;

namespace Book.Chapter_6 {


    class Question_9 {
       
        public static void Solution()
        {
            bool stay = true;

            while (stay)
            {
                Write("Char use: ");
                if (!char.TryParse(ReadLine(), out char c)) c = '*';

                int h;
                Write("Height: ");
                while (!int.TryParse(ReadLine(), out h) || h < 2) Write("Invalid. Again: ");
                
                for (int i = 1; i <= h*2; i++)
                {
                    int end = i > h ? 2 * h - i : i;
                    for (int j = 0; j < end; j++)
                    {
                        Write($"{c}");
                    }
                    WriteLine();
                }
                

                Write("Do you want to continue? (Y/N): ");
                stay = (ReadLine().ToLower() == "y");
            }
        }
    }
}