using System.Collections;
using static System.Console;
namespace Other
{
	public class OSCache
	{
		public static void Solution()
		{
			int[] processes = { 1, 0, 2, 2, 1, 7, 6, 7, 0, 1, 2, 0, 3, 0, 4, 5, 1, 5, 2, 4, 5, 6, 7, 6, 7, 2, 4, 2, 7, 3, 3, 2, 3 };
			ArrayList map = new ();
			int size = 0;
			int[] lru = new int[4];
			string l1 = "", l2 = "";

			foreach (int p in processes)
			{
				WriteLine(p);
				int index = Array.IndexOf(lru, p);
				bool hit = true;
				if (index == -1)
				{
					hit = false;
					index = Array.IndexOf(lru, map[0]);
                    size++;
                    if (size > 4)
                    {
						map.RemoveAt(0);
						
                    }
					map.Add(p);
                }
				

                for (int i = 0; i < lru.Length; i++)
				{
					l1 += (i == index ? (hit? "v":"x") : " ");
					l2 += lru[i].ToString();
				}
				l1 += " ";
				l2 += "|";
            }
            WriteLine(l1);
            WriteLine(l2);
            ReadKey();
        }
	}
}

