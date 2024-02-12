using static System.Console;
using ClassExamples;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Student student = new Student(300, "Tim", "CIS");
            student.ManualImplementProperty = "CSIS";
            student.AutoImplementProperty = "Just Auto";
            WriteLine(student.Major);
            WriteLine(student.AutoImplementProperty);
        }
    }
}

