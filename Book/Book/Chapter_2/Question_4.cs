using System;
using static System.Console;

namespace Chapter_2 {
    class Question_4 {
        
        public static void Solution() {
            int cents = Input();
            int[] back = Compute(cents);
            Display(cents, back);
        }
        static int Input()
        {
            Write("Input number of cents: ");
            return int.Parse(ReadLine());
        }
        static int[] Compute(int cents)
        {
            int[] coinVals = new int[] { 25, 10, 5, 1 };
            int[] back = new int[4];
            for (int i = 0; i < coinVals.Length; i++)
            {
                back[i] = cents / coinVals[i];
                cents %= coinVals[i];
            }
            return back;
        }
        static void Display(int cents, int[] back)
        {

            string[] coinLabels = new string[] { "quarters", "dimes", "nickles", "pennies" };

            Write("{0:C2} cents = ", cents);
            for (int i = 0; i < coinLabels.Length; i++)
            {
                if (0 == back[i])
                {
                    continue;
                }
                if (i > 0)
                {
                    Write(", ");
                }
                Write("{0} {1}", back[i], coinLabels[i]);                
            }
        }
    }
}