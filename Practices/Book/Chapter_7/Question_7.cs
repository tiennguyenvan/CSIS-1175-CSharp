using static System.Console;

namespace Book.Chapter_7 {
    class StateCodes
    {
        private string[] codes;

        // default
        public StateCodes() { }

        // param
        public StateCodes(params string[] codes)
        {
            this.codes = new string[codes.Length];
            Array.Copy(codes, 0, this.codes, 0, codes.Length);
        }

        // search
        public bool Has(string code)
        {
            return Array.IndexOf(codes, code) != - 1;
        }

        // toString
        public override string ToString()
        {
            string content = "";
            foreach (string code in codes)
            {
                content += $"({code})";
            }
            return "State Codes\n"
                + $"{content}\n"
           ;
        }
    }
    class Question_7 {
        public static void Solution()
        {
            StateCodes codes = new(
                "AL", // Alabama
                "AK", // Alaska
                "AZ", // Arizona
                "CA", // California
                "CO", // Colorado
                "FL", // Florida
                "GA", // Georgia
                "IL", // Illinois
                "NY", // New York
                "TX"  // Texas
            );

            WriteLine(codes);

            // search
            Write("Search for a code: ");
            if (codes.Has(ReadLine())) {
                Write("The code exits in the list!");
            } else
            {
                Write("The code does not exit in the list!");
            }

        }
    }
}