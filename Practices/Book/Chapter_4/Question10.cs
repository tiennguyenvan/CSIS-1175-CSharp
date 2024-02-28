using System;
using static System.Console;

namespace Book.Chapter_4 {
    class Money
    {
        // consts
        // fields and properties        
        public int totalCents = 0;


        // default
        public Money() {
            totalCents = 1000;
        }
        // param
        public Money(
            int dollars,
            int cents
        ) {            
            totalCents = dollars * 100 + cents;            
        }
        // methods
        public void IncrementMoney(int amount)
        {
            totalCents += amount;
        }
        public void DecrementMoney(int amount)
        {
            totalCents -= amount;
        }
        public string MoneyBreakdown()
        {
            int pennies = totalCents;
            int dollars = pennies / 100;
            pennies %= 100;
            int quarters = pennies / 25;
            pennies %= 25;
            int nickles = pennies / 10;
            pennies %= 10;
            int dimes = pennies / 5;            
            pennies = pennies % 5;

            return "Money Breakdown:\n"
                + $"Total Cents: {totalCents}\n"
                + $"--------------------------\n"
                + (0 != dollars ? $"{dollars} dollars\n" : "")
                + (0 != quarters ? $"{quarters} quarters\n" : "")
                + (0 != nickles ? $"{nickles} nickles\n" : "")
                + (0 != dimes ? $"{dimes} dimes\n" : "")
                + (0 != pennies ? $"{pennies} pennies\n" : "")
            ;
        }

        public override string ToString()
        {
            decimal totalDollars = (decimal)totalCents / 100;
            return $"Total Dollars: {totalDollars:c}";
        }
    }
    class Question10 {
        public static void Solution()
        {
            Money money = new(
                dollars: 10,
                cents: 69
            );

            WriteLine(money.MoneyBreakdown());
            WriteLine(money.ToString());
        }
    }
}