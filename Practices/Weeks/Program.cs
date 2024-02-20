using static System.Console;

namespace VanTien
{
    class Program
    {
        static void Main()
        {

            if (Cond1() || Cond2() && true)
            {
                WriteLine("Sure");
            }
            ReadKey();
        }
        static bool Cond1()
        {
            WriteLine(1);
            return true;
        }
        static bool Cond2()
        {
            WriteLine(2);
            return true;
        }
    }
}