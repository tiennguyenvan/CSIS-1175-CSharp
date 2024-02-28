using System;
using static System.Console;

namespace Book.Chapter_5 {
    class PoolHealth
    {
        // consts
        const double NEUTRAL_LVL = 7;
        const double MAX_LVL = 7.8;

        // fields & props
        public double pHLevel = 0;

        // default
        public PoolHealth() { }

        // param
        public PoolHealth(
            double pHLevel
        ) {
            
            this.pHLevel = pHLevel;
        }

        // show ph label
        public string PHLabel()
        {
            if (pHLevel == NEUTRAL_LVL) return "neutral";
            if (pHLevel < NEUTRAL_LVL) return "acidic";

            return "alkaline";
        }
        
        // show php additive name
        public string PHAdditive()
        {
            if (pHLevel < NEUTRAL_LVL) return "bases";
            if (pHLevel > MAX_LVL) return "acids";
            return "";
        }

        public string HealthMessage()
        {
            string label = PHLabel();
            string additive = PHAdditive();
            additive = additive != "" ? $"Addictive ({additive}) is required" : "No need an additive";

            return "----------------------------\n"
                + "Pool pH Health Report\n"
                + $"pH Level: {pHLevel}\n"
                + $"pH Label: {label}\n"
                + $"{additive}\n"
            ;
        }
    }
   
    class Question_2
    {
        public static void Solution()
        {
            Write("Input the pH level: ");
            if (!double.TryParse(ReadLine(), out double pHLevel))
            {
                WriteLine("The input is not a number. Program ended!");
                return;
            }
            if (pHLevel < 0 || pHLevel > 14)
            {
                WriteLine("Input value is out of range (0, 14)");
                return;
            }

            PoolHealth pool = new(pHLevel: pHLevel);
            WriteLine(pool.HealthMessage());
        }
        
    }
}