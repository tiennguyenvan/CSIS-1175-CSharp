using static System.Console;

namespace Book.Chapter_5{
    class ImperalBMI
    {
        // fields and props
        double weight = 0;
        double height = 1;

        // param construct
        public ImperalBMI(
            double weight,
            double height
            )
        {
            this.weight = weight;
            this.height = height != 0 ? height : 1;

        }

        // BMI
        public double BMI()
        {
            return weight / (height * height);
        }
    }
    class MetricBMI
    {
        // fields and props
        double weight = 0;
        double height = 1;

        // param construct
        public MetricBMI(
            double weight,
            double height
            )
        {
            this.weight = weight;
            this.height = height != 0 ? height : 1;

        }

        // BMI
        public double BMI()
        {
            return 708 * weight / (height * height);
        }
    }
    class Question_3 {        

        public static void Solution() {
           ImperalBMI person = new(
               weight: 65,
               height: 1.7
           );

            string BMILabel;
            double BMI = person.BMI();

            if (BMI < 18.5) BMILabel = "Thin";
            else if (BMI < 24.9) BMILabel = "Perfect";
            else if (BMI < 29.9) BMILabel = "Fat";
            else BMILabel = "Elephant";

            WriteLine($"Your BMI is: {BMILabel}");
        }

        
    }
}