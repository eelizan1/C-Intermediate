using System;


// 1. Signaure of a Method
//      - Name
//      - Number and Type of parameters 
//
// 2. Overloading Methods 
//      - Having a method with the same name but different signatures 
//
// 3. Params modifier 
//      Allows you to reduce the number of methods being overloaded
//      Can pass a varying number of arguments
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }

        static void useParams()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(3, 4, 5, 7);
            var sumArray = calculator.Add(new int[] { 1, 3, 4 });
            Console.WriteLine(sum);
            Console.WriteLine(sumArray);
            
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(12, 45);
                Console.WriteLine("x: {0}, y: {1}", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("x: {0}, y: {1}", point.x, point.y);
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
    }
}