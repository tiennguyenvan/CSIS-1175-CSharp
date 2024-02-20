using System;
using System.Xml.Linq;
using static System.Console;

namespace Book.Chapter_4 {
    class Park
    {
        // props
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Facility { get; set; }
        public double Fee { get; set; }
        public int Employees { get; set; }
        public int Visitors { get; set; }
        public double Budget { get; set; }

        // default
        public Park() { }

        // params
        public Park(
            string _Name, 
            string _Location, 
            string _Type, 
            string _Facility, 
            double _Fee, 
            int _Employees, 
            int _Visitors, 
            double _Budget
        )
        {
            Name = _Name;
            Location = _Location;
            Type = _Type;
            Facility = _Facility;
            Fee = _Fee;
            Employees = _Employees;
            Visitors = _Visitors;
            Budget = _Budget;
        }

        // full name
        public string NameLocationType()
        {
            return $"{Name}, {Location}, {Type}";
        }

        // full name facility
        public string NameLocationFacility()
        {
            return $"{Name}, {Location}, {Facility}";
        }

        // cost
        public double CostPerVisitor()
        {
            return Visitors == 0 ? 0 : Budget / Visitors;
        }

        // revenue
        public double Revenue()
        {
            return Fee * Visitors;
        }

        // toString overriding
        public override string ToString()
        {
            return $"Name: {Name}\n"
                + $"Location: {Location}\n"
                + $"Type: {Type}\n"
                + $"Facility: {Facility}\n"
                + $"Fee: {Fee:c}\n"
                + $"Employees: {Employees}\n"
                + $"Visitors: {Visitors}\n"
                + $"Budget: {Budget:c}\n"
            ;
        }
    }
    class Question_7 {
        public static void Solution()
        {
            Park park = new(
                _Name : "Tokyo",
                _Location : "Tokyo",
                _Type : "Public",
                _Facility : "Public",
                _Fee : 5,
                _Employees : 100,
                _Visitors : 300000,
                _Budget : 500000
            );

            WriteLine(park.ToString());
        }
    }
}