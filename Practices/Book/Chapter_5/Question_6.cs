using static System.Console;

namespace Book.Chapter_5 {
    class Input6
    {
        // input methods
        public static string String(string label)
        {
            Write($"{label}: ");
            return ReadLine();
        }

        public static int Int(string label)
        {
            if (int.TryParse(String(label), out int value)) return value;
            return 0;
        }
        public static double Double(string label)
        {
            if (double.TryParse(String(label), out double value)) return value;
            return 0;
        }
    }
    class MultiCalculator
    {
        // fields & props
        double radius = 0;
        double length = 0;
        double width = 0;
        double height = 0;
        int formula = 1;


        static void Menu()
        {
            Write("Formulas:\n"
                + "1. Area of a circle = pi * radius^2\n"
                + "2. Area of a rectangle = length * width\n"
                + "3. Surface area of a cylinder = 2 * pi * radius * height + 2 * pi * radius^2\n"
            );
        }
        static int Selected()
        {
            Write("Please input the formula number you want to calculate: ");
            if (!int.TryParse(ReadLine(), out int value))
            {
                return 1;
            }

            if (value < 1) return 1;
            if (value > 3) return 3;
            return value;
        }

        public void Input()
        {
            Menu();
            formula = Selected();
            switch (formula)
            {
                case 1:
                    radius = Input6.Double("Input Radius");                    
                    break;
                case 2:
                    length = Input6.Double("Input Length");
                    width = Input6.Double("Input Width");                    
                    break;
                case 3:
                    radius = Input6.Double("Input Radius");
                    height = Input6.Double("Input Height");                    
                    break;
            }            
        }
        public double Compute() {
            return formula switch
            {
                1 => F1(),
                2 => F2(),
                3 => F3(),
                _ => F1(),
            };
        }

        public double F1 ()
        {
            return Math.PI * radius * radius;
        }
        public double F2()
        {
            return length * width;
        }
        public double F3()
        {
            return 2 * Math.PI * radius * (height + radius);
        }
    }
    class Question_6 {        
        
        public static void Solution() {
            MultiCalculator calculator = new();
            calculator.Input();
            WriteLine($"{calculator.Compute():F2}");
        }
    }
}