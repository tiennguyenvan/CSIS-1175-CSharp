using System;
using System.Xml.Linq;
using static System.Console;

namespace Book.Chapter_4 {
    class Employee2
    {
        // CONSTANTS
        const decimal COMMISSION_RATE = 7M / 100;
        const decimal FEDERAL_TAXT_RATE = 18M / 100;
        const decimal RETIREMENT_CONTRIBUTION_RATE = 10M / 100;
        const decimal SOCIAL_SECURITY_TAX_RATE = 6M / 100;

        // fields & props
        private decimal commision = 0;
        private decimal federalTax = 0;
        private decimal retirementContribution = 0;
        private decimal socialSecurityTax = 0;
        private decimal takeHome = 0;

        public string Name { get; set; }
        public decimal WeekSales { get; set; }

        // default
        public Employee2()
        {
     
        }
        // param
        public Employee2(
            string Name,
            decimal WeekSales
        )
        {
            this.Name = Name ;
            this.WeekSales = WeekSales;
            TakeHome();
        }
        // methods
        public decimal Commision()
        {
            commision = WeekSales * COMMISSION_RATE;
            return commision;
        }
        public decimal FederalTax()
        {
            federalTax = WeekSales * FEDERAL_TAXT_RATE;
            return federalTax;
        }
        public decimal RetirementContribution()
        {
            retirementContribution = WeekSales * RETIREMENT_CONTRIBUTION_RATE;
            return retirementContribution;
        }
        public decimal SocialSecurityTax()
        {
            socialSecurityTax = WeekSales * SOCIAL_SECURITY_TAX_RATE;
            return socialSecurityTax;
        }
        public decimal TakeHome()
        {
            takeHome = WeekSales - Commision() - FederalTax() - RetirementContribution() - SocialSecurityTax();
            return takeHome;
        }
        public override string ToString()
        {
            return
                "-----------------------------------------\n"
                + "Employee Report\n"
                + "-----------------------------------------\n"
                + $"Name: {Name}\n"
                + $"WeekSale: {WeekSales:c}\n"
                + $"Commission: {commision:c}\n"
                + $"Federal Tax: {federalTax:c}\n"
                + $"Retirement Contribution: {retirementContribution:c}\n"
                + $"Social Security Tax: {socialSecurityTax:c}\n"
                + "-----------------------------------------\n"
                + $"Take Home: {takeHome:c}\n"
            ;
        }
    }
    
    class Question_8 {
        public static string EnterString(string label)
        {
            Write($"Enter {label}: ");
            return ReadLine();
        }
        public static decimal EnterDecimal(string label)
        {
            if (decimal.TryParse(EnterString(label), out decimal value))
            {
                return value;
            }
            return 0;
        }
        public static void Solution()
        {
            Employee2 employee2 = new(
                Name: EnterString("name"),
                WeekSales: EnterDecimal("weekly salles")
            );

            WriteLine(employee2.ToString());
        }
    }
}