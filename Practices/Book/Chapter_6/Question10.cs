using System;
using static System.Console;

namespace Book.Chapter_6 {


    class Question10 {
        public static void Solution()
        {
            bool input = true;
            int courses = 0;
            double grades = 0;
            int credits = 0;
            while (input)
            {
                int credit;
                Write("Credits: ");
                while (!int.TryParse(ReadLine(), out credit)) Write("Invalid. Again: ");

                char grade;
                Write("Grade (A, B, C, D): ");
                while (!char.TryParse(ReadLine().ToLower(), out grade)) Write("Invalid. Again: ");

                courses++;
                int rate = 0;
                if (grade == 'a') rate = 4;
                else if (grade == 'b') rate = 3;
                else if (grade == 'c') rate = 2;
                else if (grade == 'd') rate = 1;
                grades += rate * credit;
                credits += credit;
                    
                Write("Do you want to input another course? (Y/N): ");
                input = ReadLine().ToLower() == "y";
            }

            Write($"Your GPA is {(grades/credits):F2}");
        }
    }
}