using System;
using static System.Console;

namespace Book.Chapter_3 {
    class Question_9 {
        const double CommissionRate = .07;
        const double FederalTaxRate = .18;
        const double RetirementRate = .15;
        const double SocialSecurityTaxRate = .09;

        public static void Solution() {
            Input(out string name, out double sales);
            Calculation(sales,
                out double commission, out double federalTax,
                out double retirement, out double socialSecurity, out double takeHome
            );
            Display(sales, name,
                commission, federalTax,
                retirement, socialSecurity, takeHome
            );
        }
        static void Input(out string name, out double sales)
        {
            Write("Input employee name: ");
            name = ReadLine();
            Write("Input amout of sales $");
            sales = double.Parse(ReadLine());
        }

        static void Calculation(double sales,
            out double commission, out double federalTax,
            out double retirement, out double socialSecurity, out double takeHome
        )
        {
            commission = sales * CommissionRate;
            federalTax = commission * FederalTaxRate;
            retirement = commission * RetirementRate;
            socialSecurity = commission * SocialSecurityTaxRate;
            takeHome = commission - federalTax - retirement - socialSecurity;
        }

        static void Display(double sales, string name,
            double commission, double federalTax,
            double retirement, double socialSecurity, double takeHome
        )
        {
            WriteLine("----------------------------------------");
            WriteLine("Take-home report for: {0}", name);
            WriteLine("----------------------------------------");
            WriteLine("Total sales: {0:C2}", sales);
            WriteLine("----------------------------------------");
            WriteLine("Commission ({0:P2}): +{1:C2}", CommissionRate, commission);
            WriteLine("Federal Tax ({0:P2}): -{1:C2}", FederalTaxRate, federalTax);
            WriteLine("Retirement ({0:P2}): -{1:C2}", RetirementRate, retirement);
            WriteLine("Social Security Tax ({0:P2}): -{1:C2}", SocialSecurityTaxRate, socialSecurity);
            WriteLine("----------------------------------------");
            WriteLine("TAKE-HOME: {0:C}", takeHome);

        }
    }
}