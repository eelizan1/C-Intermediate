using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 5 };

            //// Length - returns the size of the array
            //Console.WriteLine(numbers.Length);

            //// IndexOf()
            //Console.WriteLine(Array.IndexOf(numbers, 9));

            //Console.WriteLine("------------");

            //// Clear(array, starting index, # of elements to clear)
            //// sets items to 0 
            //Array.Clear(numbers, 0, 2);

            //foreach(var n in numbers)
            //{
            //    Console.Write(n);
            //}

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3); // copy first three elements in array

            //Console.WriteLine("Effect of copy");
            //foreach (var n in another)
            //    Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);

            Console.Read();
        }
    }
}