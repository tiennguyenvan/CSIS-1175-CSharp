using System;
using System.Xml.Linq;
using static System.Console;

namespace Book.Chapter_4 {
    class ProfessorRating
    {
        // consts

        // fields & props
        private int id = 0;
        public string Name { get; set; }
        public double Easiness { get; set; }
        public double Helpfulness { get; set; }
        public double Clarity { get; set; }        


        // default
        public ProfessorRating()
        {
            Name = "";
            Easiness = 0;
            Helpfulness = 0;
            Clarity = 0;
        }

        // param
        public ProfessorRating(
            int id,
            string Name,
            double Easiness,
            double Helpfulness,
            double Clarity

        )
        {
            this.id = id;
            this.Name = Name;
            this.Easiness = Easiness;
            this.Helpfulness = Helpfulness;
            this.Clarity = Clarity;

        }

        public double AverageRating()
        {
            return (Easiness + Helpfulness + Clarity) / 3;
        }
    }
    class Question_9 {
        public static string EnterString(string label)
        {
            Write($"Enter {label}: ");
            return ReadLine();
        }
        public static double EnterDouble(string label)
        {
            if (double.TryParse(EnterString(label), out double value))
            {
                return value;
            }
            return 0;
        }
        public static int EnterInt(string label)
        {
            if (int.TryParse(EnterString(label), out int value))
            {
                return value;
            }
            return 0;
        }
        public static void Solution()
        {
            ProfessorRating professor = new(
                   id: EnterInt("id"),
                   Name: EnterString("name"),
                   Easiness: EnterDouble("easiness"),
                   Helpfulness: EnterDouble("helpfulness"),
                   Clarity: EnterDouble("clarity")
            );
            WriteLine($"Average Rating {professor.AverageRating():F0}");
        }
    }
}