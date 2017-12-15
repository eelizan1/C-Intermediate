using System;

namespace Methods
{
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
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(12, 45);
            Console.WriteLine("x: {0}, y: {1}", point.x, point.y);

            point.Move(100, 200);
            Console.WriteLine("x: {0}, y: {1}", point.x, point.y);
            Console.Read();
        }
    }

    public class Point
    {
        public int x;
        public int y; 

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            // reassign values 
            this.x = x;
            this.y = y;
        }
        // method overload - takes in a point object
        public void Move(Point newLocation)
        {
            //check if null
            if (newLocation == null)
                    throw new ArgumentNullException("newLocation");
            Move(newLocation.x, newLocation.y);
        }
    }
}