using static System.Console;

namespace Book.Chapter_6 {    
    class Question_6 {        
        
        public static void Solution() {
            string hex = "";
            char c;
            long dec = 0;
            Write("Input a Hex number (Enter to end): 0x");
            while (true)
            {
                c = ReadKey().KeyChar;
                if (c == '\n' || c == '\r') break;

                c = char.ToUpper(c);
                if (char.IsDigit(c))
                {
                    hex += c;                    
                    dec = dec * 16 + (c - '0');
                } else if (c >= 'A' && c <= 'F') {
                    hex += c;                    
                    dec = dec * 16 + (c - 'A') + 10;                    
                } else
                {
                    hex = "";
                    dec = 0;
                    Write("Invalid Hex. Again (Enter to end): 0x");
                }                
            }
            Write(
                "\n-----------------------------\n"
                + $"Hex Number: 0x{hex}\n"
                + $"Dec Number: {dec}\n"
            );

        }
    }
}