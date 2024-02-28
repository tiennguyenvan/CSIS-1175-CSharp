using System;
using static System.Console;

namespace Book.Chapter_5 {
	class Input4
	{
		// input methods
		public static string String(string label)
		{
			Write($"{label}: ");
			return ReadLine();
		}
		
		public static int Int(string label)
		{
			if (int.TryParse(String(label), out int value)) return value;
			return 0;
		}
		public static double Double(string label)
		{
			if (double.TryParse(String(label), out double value)) return value;
			return 0;
		}
	}
	class TakeHomeEmployee
	{

		// consts
		const double OVERTIME_POINT = 40;
		const double OVERTIME_RATE = 1.5;
		const double FED_RATE = .18;
		const double RETIRE = .1;
		const double SOCIAL = .06;

		// fields + props
		string fname = "";
		string lname = "";
		int id = 0;
		bool hourly = false;
		double salary = 0;
		double hourRate = 0;
		double workHours = 0;
		
		double fedTax = 0;
		double retire = 0;
		double social = 0;
		double takeHome = 0;


		// param
		public TakeHomeEmployee(	
		)
		{
			fname = Input4.String("Input First Name");
			lname = Input4.String("Input Last Name");
			id = Input4.Int("Input ID");
			hourly = Input4.String("Are you working hourly? (Y/N)") == "Y";

			if (hourly)
			{
				hourRate = Input4.Double("Input Hour Rate");
				workHours = Input4.Double("Input Work Hours");
				if (workHours > OVERTIME_POINT)
				{
					workHours = (workHours - OVERTIME_POINT) * OVERTIME_RATE + OVERTIME_POINT;
				}

				salary = hourRate * workHours;
			} else
			{
				salary = Input4.Double("Input Salary");
			}
		}

		// compute and output
        public override string ToString()
        {
			fedTax = salary * FED_RATE;
			retire = salary * RETIRE;
			social = salary * SOCIAL;
			takeHome = salary - fedTax - retire - social;


			return "-----------------------\n"
				+ $"Employee Report\n"
                + "-----------------------\n"
                + $"First Name: {fname}\n"
                + $"Last Name: {lname}\n"
                + $"ID: {id}\n"
                + "-----------------------\n"
                + $"Work Type: {(hourly ? "Hourly" : "Salaried")}\n"
                + $"Salary: {salary:C}\n"                
                + "-----------------------\n"
                + $"Federal Tax: {fedTax:c}\n"
                + $"Retire Fund: {retire:C}\n"
                + $"Social Tax:L {social:c}\n"
                + "-----------------------\n"
                + $"Take Home: {takeHome:c}\n"
                

            ;
        }


    }

	class Question_4 {
		
		public static void Solution() {
			TakeHomeEmployee employee = new();

			WriteLine(employee.ToString());

		}
	   
	}
}