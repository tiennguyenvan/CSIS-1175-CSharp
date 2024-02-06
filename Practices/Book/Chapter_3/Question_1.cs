using System;
using static System.Console;
namespace Book.Chapter_3
{
	public class Question_1
	{
		public static void Solution()
		{
			string name = Input("name");
			string favorite = Input("favorite saying");
			Display(name, favorite);
		}

		static string Input(string label)
		{
			Write("Please input your {0}: ", label);
			return ReadLine();
		}
        
		static void Display(string name, string favorite)
		{
			WriteLine("-------------------------------------------------");
			WriteLine("<Message><Name: {0}><Favorite saying: {1}>", name, favorite);
		}
	}
}

