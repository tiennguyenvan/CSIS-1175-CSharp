using System;
using static System.Console;

namespace Book.Chapter_7 {
	

	class Question_4 {

		public static int Max(int a, int b, int c)
		{
			return Math.Max(a, Math.Max(b, c));
		}
		public static void Solution() {
			int[] valid = new int[100];
            int[] outrange = new int[100];
            string[] invalid = new string[100];

			int validCount = 0, outRangeCount = 0, invalidCount = 0;

			Write("Input numbers from 0 to 10. -99 to exist\nFirst number: ");
			string inp;
			while ((inp = ReadLine()) != "-99" && validCount < 100 && outRangeCount < 100 && invalidCount < 100) {
				
				if (!int.TryParse(inp, out int value))
				{
					Write("Invalid. Again: ");
					invalid[invalidCount++] = inp;
					continue;
				}

				if (value < 0 || value > 10)
				{
                    Write("Out of range. Again: ");
                    outrange[outRangeCount++] = value;
					continue;
				}
                Write("Correct. Again: ");
                valid[validCount++] = value;
			}
			string[] label = { "Valid", "Out Range", "Invalid" };
            string separator = new string('-', label[0].Length + label[1].Length + label[2].Length + 6);
            WriteLine(separator);            			
            Write($"{label[0]} | {label[1]} | {label[2]}\n");
            WriteLine(separator);

			for (int i = 0; i < Max(validCount, outRangeCount, invalidCount); i++)
			{
				string val0 = i < validCount ? valid[i].ToString() : "";
				string val1 = i < outRangeCount ? outrange[i].ToString() : "";
				string val2 = i < invalidCount ? invalid[i].ToString() : "";

				Write("{0,-" + label[0].Length +"} | {1,-" + label[1].Length + "} | {2,-" + label[2].Length +"}\n", val0, val1, val2);
            }
            WriteLine(separator);
            Write("{0,-" + label[0].Length + "} | {1,-" + label[1].Length + "} | {2,-" + label[2].Length + "}\n", validCount, outRangeCount, invalidCount);
        }    
	   
	}
}