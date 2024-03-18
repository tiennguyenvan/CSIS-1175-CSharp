using static System.Console;

namespace Book.Chapter_7{   
	class Question_3 {        

		public static void Solution() {
			double[] d1 = { 1.2, 2.1, 3.5, 4.8 };
			double[] d2 = { 4.4, 4.1, 6.3, 3.4, 7.6 };
			int len = Math.Min(d1.Length, d2.Length);
			double[] p = new double[len];

			for (int i = 0; i < len; i++) p[i] = d1[i] * d2[i];
			for (int i = 0; i < len; i++) WriteLine($"{i}: {p[i]}");

        }		
	}
}