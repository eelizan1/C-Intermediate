using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1992, 1, 1));
            //person.Birthdate = new DateTime(1992, 1, 1);
            Console.WriteLine(person.Age);
            Console.Read();
        }
    }

    public class Person
    {
        // making the set private allows you to set the birthday only once
        // should make the birthday in the constructor
        public DateTime Birthdate { get; private set; }
        // shortcut: "prop" + tab
        public string Name { get; set; }

        public int Age
        {
            // get accessor method
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years; 
            }
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }
}
