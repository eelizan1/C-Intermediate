using System;

namespace ObjectInitializer
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime Birthdate; 
    }
    class Program
    {
        // Object Initializer - A syntax for quickly initialising an object without the need to call one of its constructors
        // avoids creating multiple constructors
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "Mosh",
                LastName = "Hamdedani"
            };
            Console.Read();
        }
    }
}