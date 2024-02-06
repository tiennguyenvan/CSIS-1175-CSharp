using System;
using static System.Console;
using System.Linq;

namespace Book.Chapter_3{
    class Question_3 {
        public static void Solution() {
            Input(out double width, out double height);
            Compute(width, height, out double area, out double perimeter);
            Display(area, perimeter);
        }
        static void Input(out double width, out double height)
        {
            Write("Input the rectangle width: ");
            width = double.Parse(ReadLine());
            Write("Input the rectangle height: ");
            height = double.Parse(ReadLine());
            
        }
        static void Compute(double width, double height, out double area, out double perimeter)
        {
            area = width * height;
            perimeter = 2 * width * height;
        }
        static string Pad(int num)
        {
            return string.Format("{0," + num + "}", "");
        }

        static void Display(double area, double perimeter)
        {
            double areaSPad = ((double) 13 - area.ToString("F2").Length) / 2;
            double periSPad = ((double) 13 - perimeter.ToString("F2").Length) / 2;
            
            WriteLine("-----------------------------");
            WriteLine("|    Area     |  Perimeter  |");
            WriteLine("-----------------------------");
            WriteLine("|{0}{1:F2}{2}|{3}{4:F2}{5}|",
                Pad((int)Math.Ceiling(areaSPad)), area, Pad((int)Math.Floor(areaSPad)),
                Pad((int)Math.Ceiling(periSPad)), perimeter, Pad((int)Math.Floor(periSPad))
            );            
            WriteLine("-----------------------------");
        }
    }
}