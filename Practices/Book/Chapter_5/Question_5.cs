using System;
using static System.Console;

namespace Book.Chapter_5 {
    // 1: 2.99
    // 2 - 5: 1.99
    // 6 - 14: 1.49
    // 15: 0.99           
    class Question_5 {
        // consts
        const decimal R1 = 2.99m; 
        const decimal R2 = 1.99m;
        const decimal R6 = 1.49m;
        const decimal R15 = 0.99m;

        public static void Solution() {
            Write("Input number of Items: ");
            if (!int.TryParse(ReadLine(), out int items) || items < 1)
            {
                WriteLine("The number items is not valid. Program Ended");
                return;
            }
            
            decimal shippping = 0;
            Write($"Total Shipping for {items} items is: ");
            if (items > 14)
            {
                shippping += R15 * (items - 14);
                items = 14;
            }
            if (items > 5)
            {
                shippping += R6 * (items - 5);
                WriteLine($"{shippping:c}");
                items = 5;
            }
            if (items > 1)
            {
                shippping += R2 * (items - 1);
                WriteLine($"{shippping:c}");
                items = 1;
            }
            shippping += R1 * items;
            

            WriteLine($"{shippping:c}");

        }
    }
}