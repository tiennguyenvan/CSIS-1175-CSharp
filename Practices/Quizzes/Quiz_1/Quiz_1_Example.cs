using static System.Console;
/*
 Assume that a gallon of paint covers about 350 square feet of wall space. Create a class named PaintCalculator (with main) that asks the user for the length and width of a rectangular room. Create a method named CalculateArea() that calculates the wall area for a room. Pass the values of length and width to a method named CalculateArea which should calculate the area for the room and return the area.
Area = length * width.
 
Create another method named CalculateNumGallons() that accepts the calculated wall area and returns the number of gallons of paint needed. Number of gallons = area / square feet covered by a gallon of paint.
 
Create another method named CalculatePrice() that calculates the price based on a paint price of $32 per gallon, assuming that the painter can buy any fraction of a gallon of paint at the same price.
 
The output should be formatted and displayed with appropriate messages. The price should be formatted in currency format.
 */


namespace Quizzes.Quiz_1
{
    class PaintCalculator
    {
        const double SQF_PER_GALLON = 350;
        const double PRICE_PER_GALLON = 32;

        static double InputDimension(string label)
        {
            Write($"Input room's {label} in feet: ");
            return double.Parse(ReadLine());
        }
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculateNumGallons(double area)
        {
            return area / SQF_PER_GALLON;
        }
        static double CalculatePrice(double gallons)
        {
            return gallons * PRICE_PER_GALLON;
        }
        
        public static void Solution()
        {
            double length = InputDimension("length");
            double width = InputDimension("Width");
            double area = CalculateArea(length, width);
            double gallons = CalculateNumGallons(area);
            double price = CalculatePrice(gallons);
            WriteLine("-----------------------------------------");
            WriteLine("Room Painting Cost:");
            WriteLine("-----------------------------------------");
            WriteLine($"Area: {length:F2} x {width:F2} = {area:F2} sqf");
            WriteLine($"Gallons Needed: {area:F2} / {SQF_PER_GALLON:F2} (sqt per gal) = {gallons:F2} gal");
            WriteLine($"TOTA COST: {gallons:F2} * {PRICE_PER_GALLON:C2} (price per gal) = {price:C2}");
        }
    }
}