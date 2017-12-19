using System;

namespace Methods
{
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
            // uses previous method so you don't have to rewrite
            Move(newLocation.x, newLocation.y);
        }
    }
}