using System;
using static System.Console;

namespace Book.Chapter_6 {
    // 1: 2.99
    // 2 - 5: 1.99
    // 6 - 14: 1.49
    // 15: 0.99           
    class Question_5 {
        public static void Solution() {
            int items;
            Write("Input number of Items: ");            
            while (!int.TryParse(ReadLine(), out items) || items < 1)
            {
                Write("Invalid # of items. Again: ");                
            }

            double price;
            Write("Input item price: ");            
            while (!double.TryParse(ReadLine(), out price) || price < 1)
            {
                Write("Invalid item price. Again: ");
            }

            double totalPurchase = price * items;
            double saleTax = totalPurchase * 0.0775;
            double shipping;
            if (items > 15) shipping = 10;
            else if (items > 10) shipping = 9;
            else if (items > 6) shipping = 7;
            else if (items > 2) shipping = 5;
            else shipping = 3.5;

            WriteLine(
                "------------------------------\n"
                + $"Total Items: {items}\n"
                + $"Item Price: {price:C}\n"
                + $"Total: {totalPurchase:c}\n"
                + $"+ Tax: {saleTax:c}\n"
                + $"+ Shipping: {shipping:c}\n"
                +"------------------------------\n"
                + $"Grand Total: {(totalPurchase + saleTax + shipping):C}\n"
            );

        }
    }
}