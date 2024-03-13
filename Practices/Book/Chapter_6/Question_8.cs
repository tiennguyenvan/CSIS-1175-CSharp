using static System.Console;

namespace Book.Chapter_6 {
   
	class Question_8 {

        public static void Swap(ref double a, ref double b)
        {
            if (a > b) return;
            double temp = a;
            a = b;
            b = temp;
        }
		public static void Solution()
		{
			bool stay = true;

			while (stay)
			{
                double a;
                Write("First Edge: ");
                while (!double.TryParse(ReadLine(), out a) || a <= 0)
                {
                    Write("Invalid. Again: ");
                }

                double b;
                Write("Second Edge: ");
                while (!double.TryParse(ReadLine(), out b) || b <= 0)
                {
                    Write("Invalid. Again: ");
                }

                double c;
                Write("Third Edge: ");
                while (!double.TryParse(ReadLine(), out c) || c <= 0)
                {
                    Write("Invalid. Again: ");
                }

                Swap(ref a, ref b); Swap(ref a, ref c);
                string recLabel = (a * a == b * b + c * c) ? "" : "not "; 
                WriteLine($"{a}, {b}, and {c} are {recLabel}the edges of a rectangle");

                Write("Do you want to continue? (Y/N): ");
                stay = (ReadLine().ToLower() == "y");
            }
		}
	}
}