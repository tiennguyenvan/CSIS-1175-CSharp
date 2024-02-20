using System;
using static System.Console;

namespace Book.Chapter_4 {
    class Student
    {
        // required fields
        int number = 0;
        string firstName = "";
        string lastName = "";
        string classification = "";
        string major = "";

        public int Number { get { return number; } set { number = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Classification { get { return classification; } set { classification = value; } }
        public string Major { get { return major; } set { major = value; } }

        // default constructor
        public Student() { }

        // parameterized constructor
        public Student(
            int number = 0,
            string firstName = "", string lastName = "",
            string classification = "", string major = ""
        )
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Classification = classification;
            Major = major;
        }

        // display Full name
        public void DisplayFullName()
        {
            WriteLine($"Fullname: {FirstName} {LastName}");
        }
    }
   
    class Question_2
    {
        public static void Solution()
        {
            Student me = new(
                number: InpInt("number"),
                firstName: InpStr("first name"),
                lastName: InpStr("last name"),
                classification: InpStr("classfication"),
                major: InpStr("major")
            );
            me.DisplayFullName();
            WriteLine($"Major: {me.Major}");

        }
        static string InpStr(string label)
        {
            Write($"Input {label}: ");
            return ReadLine();
        }
        static int InpInt(string label)
        {
            return int.TryParse(InpStr(label), out int value) ? value : 0;
        }
    }
}