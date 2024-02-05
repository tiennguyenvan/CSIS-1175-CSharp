using System;
using static System.Console;

namespace Chapter_3 {
    class Question10 {
        const double MillagePerK = 10.03;
        const double Exemption = 25000;
        const double IncreaseRate = .027;

        public static void Solution() {
            Input(out double propertyPrice);
            Compute(propertyPrice,
                out double exemptedPrice, out double currentTax,
                out double newMillagePerK, out double newTax
            );
            Display(propertyPrice,
                exemptedPrice, currentTax,
                newMillagePerK, newTax
            );
        }
        static void Input(out double propertyPrice)
        {
            Write("Input property price: $");
            propertyPrice = double.Parse(ReadLine());
        }
        static void Compute(double propertyPrice,
            out double exemptedPrice, out double currentTax,
            out double newMillagePerK, out double newTax
        )
        {
            exemptedPrice = propertyPrice - Exemption;
            currentTax = MillagePerK * exemptedPrice / 1000;
            newMillagePerK = MillagePerK + MillagePerK * IncreaseRate;
            newTax = newMillagePerK * exemptedPrice / 1000;
        }

        static void Display(double propertyPrice,
            double exemptedPrice, double currentTax,
            double newMillagePerK, double newTax)
        {
            WriteLine("------------------------------------------");
            WriteLine("Price for Taxes = {0:C2} - {1:C3} (exemption) = {2:C2}",
                propertyPrice, Exemption, exemptedPrice
            );            
            WriteLine("------------------------------------------");            
            WriteLine("Current Millage Per $1000: {0:C2}", MillagePerK);
            WriteLine("Current Tax: {0:C2}", currentTax);
            WriteLine("------------------------------------------");            
            WriteLine("New Millage Per $1000: {0:C2}", newMillagePerK);
            WriteLine("New Tax: {0:C2}", newTax);
        }
    }
}