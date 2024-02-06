using static System.Console;
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