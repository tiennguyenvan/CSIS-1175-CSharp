using System;
using static System.Console;

namespace Book.Chapter_6 {
	

	class Question_4 {
		
		public static void Solution() {
            double A = 0, B = 0, C = 0, D = 0, F = 0, count = 0;
            double sum = 0;
            
            Write("Input at least 1 score (Leave blank to exit): ");
            string input;
            while ((input = ReadLine()) != "" || count < 1)
            {
                if (!double.TryParse(input, out double score))
                {
                    Write("Invalid score. Again: ");                    
                    continue;
                }
                if (score < 0 || score > 100)
                {
                    Write("Out of range [0,100]. Again: ");                    
                    continue;
                }
                count++;
                sum += score;
                if (score >= 90) A++;
                else if (score >= 80) B++;
                else if (score >= 70) C++;
                else if (score >= 60) D++;
                else F++;
                Write("Perfect. Another: ");                
            }

            WriteLine(
                "----------------------------------------------\n"
                + $"Average Score: {(sum/count):F2}\n"
                + $"A Scores: {A}\n"
                + $"B Scores: {B}\n"
                + $"C Scores: {C}\n"
                + $"D Scores: {D}\n"                
                + $"F Scores: {F}\n"
            );
        }
	   
	}
}