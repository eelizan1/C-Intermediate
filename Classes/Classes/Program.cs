using System;

namespace Classes
{
    public class Person
    {
        public string name; 

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, name);
        }

        // creates a person object from a string
        // declare static so that you don't have to create an object just to use this method
        public static Person parse(string str)
        {
            var person = new Person();
            person.name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.name = "Enrico";
            //person.Introduce("Mark");

            var p = Person.parse("john");
            Console.WriteLine(p.name);

            Console.Read();
        }
    }
}