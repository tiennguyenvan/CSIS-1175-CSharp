using System;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book.Chapter_4 {
    class Receipt
    {
        // props
        public int Number { get; set; }
        public string PurchaseDate { get; set; }
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }

        // default
        public Receipt() { }

        // params
        public Receipt(
            int _Number,
            string _PurchaseDate,
            int _CustomerNumber,
            string _CustomerName,
            string _CustomerAddress,
            string _CustomerPhone,
            int _ItemNumber,
            string _Description,
            double _UnitPrice,
            int _Quantity
        )
        {
            Number = _Number;
            PurchaseDate = _PurchaseDate;
            CustomerNumber = _CustomerNumber;
            CustomerName = _CustomerName;
            CustomerAddress = _CustomerAddress;
            CustomerPhone = _CustomerPhone;
            ItemNumber = _ItemNumber;
            Description = _Description;
            UnitPrice = _UnitPrice;
            Quantity = _Quantity;
        }

        // total cost
        public double Cost()
        {
            TotalCost = Quantity * UnitPrice;
            return TotalCost;
        }

        // class string
        public override string ToString()
        {            
            return "RECEIPT:\n"
                + "------------------------------------\n"
                + $"Number: {Number}\n"
                + $"PurchaseDate: {PurchaseDate}\n"
                + $"CustomerNumber: {CustomerNumber}\n"
                + $"CustomerName: {CustomerName}\n"
                + $"CustomerAddress: {CustomerAddress}\n"
                + $"CustomerPhone: {CustomerPhone}\n"
                + $"ItemNumber: {ItemNumber}\n"
                + $"Description: {Description}\n"
                + $"UnitPrice: {UnitPrice:c}\n"
                + $"Quantity: {Quantity}\n"
                + "------------------------------------\n"
                + $"TOTAL COST: {TotalCost:c}\n"

            ;
        }
    }
    class Question_5 {
        public static void Solution() {
            Receipt receipt = new(
                _Number: 300,
                _PurchaseDate: "204",
                _CustomerNumber: 203,
                _CustomerName: "Tim Codex",
                _CustomerAddress: "Sneeit.Com",
                _CustomerPhone: "999",
                _ItemNumber: 900,
                _Description: "Founder of sneeit.com",
                _UnitPrice: 402,
                _Quantity: 30
            );
            receipt.Cost();
            WriteLine(receipt.ToString());
        }
    }
}