using System;
using static System.Console;

namespace Chapter_2 {
    class Question_6 {
        const double CommissionRate = 0.07;
        const double FederalTaxRate = 0.18;
        const double RetiremetnRate = 0.1;
        const double SocialSecurityRate = 0.06;

        public static void Solution() {
            double sales = Input();
            double remain = Compute(sales, out double commission, out double federtalTax,
            out double retirement, out double socialSecurity);
            Display(
                remain, commission, federtalTax,
                retirement, socialSecurity
            );
        }
        static double Input()
        {
            Write("Input Total Sales $");
            return double.Parse(ReadLine() ?? "0");            
        }
        static double Compute(
            double sales, out double commission, out double federtalTax,
            out double retirement, out double socialSecurity
        )
        {
            commission = CommissionRate * sales;
            federtalTax = FederalTaxRate * commission;
            retirement = RetiremetnRate * commission;
            socialSecurity = SocialSecurityRate * commission;

            return commission - federtalTax - retirement - socialSecurity;
        }
        static void Display(
            double remain,
            double commission, double federtalTax,
            double retirement, double socialSecurity
        )
        {
            WriteLine("-------------------------------------");
            WriteLine("EARNING REPORT:");
            WriteLine("Commission (7%): +{0:C2}", commission);
            WriteLine("Federal Tax (18%): -{0:C2}", federtalTax);
            WriteLine("Retirement Fund (10%): -{0:C2}", retirement);
            WriteLine("Social Security Fee (6%): -{0:C2}", socialSecurity);
            WriteLine("-------------------------------------");
            WriteLine("Remain: {0:C2}", remain);
        }
    }
}