using System;
using static System.Console;

namespace Book.Chapter_5 {
   

    class Question10 {
        // const
        const decimal LIT_PRICE = 1.259m;
        const decimal GAL_PRICE = 4.5m;        

        public static void Solution()
        {
            Write("Input Canadian Fuel Litters: ");
            if (!decimal.TryParse(ReadLine(), out decimal litters))
            {
                WriteLine("Invalid Input");
                return;
            }

            Write("Input American Fuel gallons: ");
            if (!decimal.TryParse(ReadLine(), out decimal gallons))
            {
                WriteLine("Invalid Input");
                return;
            }

            decimal canPrice = litters * LIT_PRICE;
            decimal usPrice = gallons * GAL_PRICE;

            if (canPrice > usPrice)
            {
                WriteLine($"US is cheaper: {usPrice:c}");
            } else
            {
                WriteLine($"Canada is cheaper: {canPrice:c}");

            }
        }
    }
}