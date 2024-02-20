using static System.Console;

namespace Book.Chapter_4 {
    class Trip
    {
        // props
        public string Dest { get; set; }
        public double Distance { get; set; }
        public double GasCost { get; set; }
        public double GasGallon { get; set; }
        public double MilePerGal { get; set; }
        public double CostPerMile { get; set; }

        // default
        public Trip() { }

        // param
        public Trip(
            string _Dest,
            double _Distance,
            double _GasCost,
            double _GasGallon
        )
        {
            Dest = _Dest;
            Distance = _Distance;
            GasCost = _GasCost;
            GasGallon = _GasGallon;
        }

        // Mile per gallon
        public double CalMilePerGallon()
        {
            MilePerGal = Distance / GasGallon;
            return MilePerGal;
        }

        // Cost per mile
        public double CalCostPerMile()
        {
            CostPerMile = GasCost / Distance;
            return CostPerMile;
        }

        // class string
        public override string ToString()
        {            
            return "TRIP INFO:\n"
                + "--------------------------------\n"
                + $"Dest : {Dest}\n"
                + $"Distance : {Distance} miles\n"
                + $"GasCost : {GasCost:c}\n"
                + $"GasGallon : {GasGallon}\n"
                + $"MilePerGal : {MilePerGal}\n"
                + "--------------------------------\n"
                + $"CostPerMile : {CostPerMile:c}\n"
            ;
        }
    }
    class Question_6 {                
        public static void Solution() {
            Trip trip = new(
                _Dest: "Sneeit.Com",
                _Distance: 67.9,
                _GasCost: 3.2,
                _GasGallon: 1.4
            );
            trip.CalMilePerGallon();
            trip.CalCostPerMile();
            WriteLine(trip.ToString());
        }
    }
}