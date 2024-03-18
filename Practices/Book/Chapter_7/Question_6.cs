using static System.Console;

namespace Book.Chapter_7 {
    class WeekTemperatures
    {
        // fields
        private double[] temp = new double[7];
        

        // default
        public WeekTemperatures() { }

        // param
        public WeekTemperatures(double[] temp)
        {
            Array.Copy(temp, 0, this.temp, 0, this.temp.Length);            
        }

        // max
        public double Max()
        {
            double max = -double.MaxValue;
            foreach (double value in temp) max = Math.Max(max, value);
            return max;
        }

        // min
        public double Min()
        {
            double min = double.MaxValue;
            foreach (double value in temp) min = Math.Min(min, value);
            return min;
        }

        // average
        public double Ave()
        {            
            double sum = 0;
            foreach (double val in temp) sum += val;

            return sum / temp.Length;
        }
        // search
        public double Search(double temp)
        {
            int total = 0;
            for (int i = 0; i < this.temp.Length; i++)
            {
                if (temp < this.temp[i]) continue;
                total++;
            }

            return total;
        }
        // to string
        public override string ToString()
        {
            string[] label = { "Date Name", "Temperature", "Status" };
            string title = "";
            for (int i = 0; i < label.Length; i++)
            {
                if (i > 0) title += " | ";
                title += label[i];
            }

            string separator = new string('-', title.Length);
            string content = "";
            double average = Ave();
            for (int i = 0; i < temp.Length; i++)
            {
                content += String.Format(
                      "{0," + label[0].Length +"} : "
                    + "{1," + label[1].Length + ":F2} | "
                    + "{2," + label[2].Length + "}\n",
                      ((DayOfWeek) i).ToString(),
                      temp[i], temp[i] > average ? "High" : "Low"
                );
            }            
            
            return separator + "\n"
                + "Temperature Report\n"
                + separator + "\n"
                + title + "\n"
                + separator + "\n"
                + content + "\n"
                + separator + "\n"
            ;
        }
    }
    class Question_6 {        
        
        public static void Solution() {

            WeekTemperatures temp = new(new double[]{10,16,23,32,20,13,10,8});
            Write(temp);
            double average = temp.Ave();
            WriteLine($"Days lower than {average:F}: {temp.Search(average)}");

        }
    }
}