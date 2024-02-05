using System;
using static System.Console;

namespace Chapter_2 {
    class Q8_GradeRecord
    {
        public string label = "";
        public double rate;
        public double score = 0;
        public double weighted;
        public Q8_GradeRecord(string _label, double _rate, double _score = 0)
        {
            label = _label;
            rate = _rate;
            if (_score != 0)
            {
                score = _score;
            }
        }
        public void SetScore(string _score)
        {
       
            if ("" != _score)
            {
                score = double.Parse(_score);
            } else
            {
                WriteLine("\b{0:F2}", score);
            }
            
            weighted = rate * score;
        }
    }
    
    class Question_8 {

        public static void Solution() {
            Q8_GradeRecord[] grades = new Q8_GradeRecord[]
            {
                new Q8_GradeRecord("Homework", .1, 97),
                new Q8_GradeRecord("Project", .35, 82),
                new Q8_GradeRecord("Quizzes", .1, 60),
                new Q8_GradeRecord("Exames", .3, 75),
                new Q8_GradeRecord("Final Exam", .15, 80)
            };

            double total = InputScores(ref grades);
            DisplayScores(total, grades);
        }

        static double InputScores(ref Q8_GradeRecord[] grades)
        {
            WriteLine("GPA CALCULATOR");
            WriteLine("----------------------------------");
            WriteLine("Please input score for each following category: ");
            double total = 0;
            foreach (Q8_GradeRecord grade in grades)
            {
                Write("{0}: ", grade.label);
                grade.SetScore(ReadLine() ?? "0");
                total += grade.weighted;
            }

            return total;
        }
        static void DisplayScores(double total, Q8_GradeRecord[] grades)
        {
            WriteLine("----------------------------------");
            foreach (Q8_GradeRecord grade in grades)
            {
                WriteLine(
                    "{0} score: {1:F2} => Weigted {2:P0}: {3:F1}",
                    grade.label, grade.score, grade.rate, grade.weighted
                );

            }
            WriteLine("----------------------------------");
            WriteLine("Final GPA: {0:F2} / 100", total);

        }

    }
}