using System;
namespace ClassExamples
{
	public class Student
	{
		public int Id {get;set;}
		public string Name {get;set;}
		public string Major {get;set;}
		public double Score1;
		public double Score2;
		public double Score3;

		// for auto, only set can be disabled
		public string AutoImplementProperty { get; set; }

		public string ManualImplementProperty
		{
			// you can disable either of them
			get { return Major;  } 
			set { Major = value; }
		}

		// overloaded constructors
		public Student()
		{
			this.Id = 0;
			this.Name = "";
			this.Major = "";
			this.Score1 = 0;
			this.Score2 = 0;
			this.Score3 = 0;

		}
        public Student(int idd, string n, string maj)
        {
            this.Id = idd;
            this.Name = n;
            this.Major = maj;
            this.Score1 = 0;
            this.Score2 = 0;
            this.Score3 = 0;
        }
        public Student(int idd, string n, string maj, double s1, double s2, double s3)
		{
			this.Id = idd;
			this.Name = n;
			this.Major = maj;
			this.Score1 = s1;
			this.Score2 = s2;
			this.Score3 = s3;
		}

 	}
}

