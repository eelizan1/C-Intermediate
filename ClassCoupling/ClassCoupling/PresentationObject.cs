using System;

namespace ClassCoupling
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Heght { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
