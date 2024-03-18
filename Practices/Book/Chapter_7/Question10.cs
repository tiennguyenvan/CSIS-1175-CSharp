using System;
using static System.Console;

namespace Book.Chapter_7 {

    class Course
    {
        private string name = "CS";
        private int current = 0;
        private int max = 100;
        const int padding = 10;

        // default
        public Course() { }

        // param
        public Course(string name, int current, int max) {
            this.name = name;
            this.current = current;
            this.max = max;
        }

        // remain
        public int Remain()
        {
            return max - current;
        }

        // toString
        public override string ToString()
        {
            return String.Format(
                  "{0," + padding+"}"
                + "{1," + padding + "}"
                + "{2," + padding + "}"
                + "{3," + padding + "}",
                name, current, max, this.Remain()
            );
        }
    }
    class Question10 {

        public static void Solution()
        {
            // init
            Course[] courses = new Course[]
            {
                new Course("CS150", 180, 200),
                new Course("CS250", 21, 30),
                new Course("CS270", 9, 20),
                new Course("CS300", 4, 20),
                new Course("CS350", 20, 20)
            };
            string[] labels = { "Name", "Current", "Max", "Remain" };
            foreach (string label in labels) Write($"{label,10}");
            WriteLine();
            foreach (Course course in courses) WriteLine(course);
            

            
        }
    }
}