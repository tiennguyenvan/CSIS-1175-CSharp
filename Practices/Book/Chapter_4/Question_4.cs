using System;
using static System.Console;

namespace Book.Chapter_4 {
    class Employee
    {
        // props
        public int Number { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string DateOfHire { get; set; } 
        public string JobDesc { get; set; } 
        public string Department { get; set; } 
        public double MonthlySalary { get; set; } 

        // default
        public Employee() { }
        public Employee(
            int number,
            string firstName, string lastName,
            string dateOfHire, string jobDesc,
            string depart, double salary
        )
        {
            Number = number;
            FirstName = firstName; LastName = lastName;
            DateOfHire = dateOfHire; JobDesc = jobDesc;
            Department = depart; MonthlySalary = salary;
        }

        // fullname
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        // fullname for sorting
        public string FullNameSorting()
        {
            return $"{LastName}, {FirstName}";
        }

        // override toString
        public override string ToString()
        {
            return $"Number: {Number}\n"
                + $"First name: {FirstName}\n"
                + $"Last name: {LastName}\n"
                + $"Date of Hire: {DateOfHire}\n"
                + $"Job Description: {JobDesc}\n"
                + $"Department: {Department}\n"
                + $"Monthly Salary: {MonthlySalary:c}\n"                
            ;
        }
    }

    class Question_4 {
        
        public static void Solution() {
            Employee me = new(
                number: 300,
                firstName: "Tim",
                lastName: "Codex",
                dateOfHire: "2024",
                jobDesc: "Founder of Sneeit.Com",
                depart: "CIS",
                salary: 15000               
            );

            WriteLine($"Full name: {me.FullName()}");
            WriteLine($"Full name sort: {me.FullNameSorting()}");
            WriteLine("-----------------------------------");
            WriteLine(me.ToString());
        }
       
    }
}