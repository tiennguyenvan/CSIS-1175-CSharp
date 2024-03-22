using static System.Console;
namespace Other
{
    class Student {
        public string name = "";
        public int id = 0;
        public Student (string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public override string ToString()
        {
            return $"- Name: {name}, id: {id}";
        }
    }
	public class ArrayClass
	{
		public static void Solution()
		{
            int[] arr = { 1, 0, 2, 2, 1, 7, 6, 7, 0, 1, 2, 0, 3, 0, 4, 5, 1, 5, 2, 4, 5, 6, 7, 6, 7, 2, 4, 2, 7, 3, 3, 2, 3 };            

            // accumulate through all elements using a function
            // 'element' starts at index 1
            WriteLine("Aggregate: " + arr.Aggregate((accumulate, e) => accumulate + e));

            // check if all elements satisfy a condition using a function
            WriteLine("All: " + arr.All((e) => e > -1));

            // check if any element satisfy a condition using a function
            WriteLine("Any: " + arr.Any((e) => e > 5));

            // average of elements
            WriteLine("Average: " + arr.Average());
            //arr.Max();
            //arr.Min();
            //arr.Sum();           

            // create a shallow (top-level) copy
            int[] arr1 = (int[])arr.Clone();

            // concat 2 arrays
            int[] arr2 = arr.Concat(arr1).ToArray();            

            // check if contain an element
            WriteLine("Contains: " + arr.Contains(7));

            // Copy elements to an index of destination array 
            int[] arr3 = new int[arr.Length];
            arr.CopyTo(arr3, 0);

            // get unique elements
            int[] unique = arr.Distinct().ToArray();

            // get unique elements using a function
            Student[] students = {
                new Student("Tim", 950),
                new Student("Horten", 950),
                new Student("Codex", 900)
            };
            Student[] distBy = students.DistinctBy(s => s.id).ToArray();            
            WriteLine("DistinctBy:");
            foreach (Student i in distBy) WriteLine(i);

            WriteLine("Reverse:");
            foreach (int i in arr.Reverse().ToArray()) Write(i + " ");
            WriteLine();

            // skip the first N elements before processing
            WriteLine("Skip:");
            foreach (int i in arr.Skip(7).ToArray()) Write(i + " ");

            // take the first N elements to process
            WriteLine("Take:");
            foreach (int i in arr.Take(7).ToArray()) Write(i + " ");


            ///////////////////////////////////////////////////////////////////
            Array.BinarySearch(arr, 7);
            Array.Copy(arr, 0, arr1, 0, 3);
            Array.IndexOf(arr, 7);
            Array.LastIndexOf(arr, 7);
            Array.Sort(arr);
            Array.Reverse(arr);

            ReadKey();
        }
	}
}

