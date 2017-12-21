using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var john = new Customer();
            //john.setName("john");
            //Console.WriteLine(john.getName());

            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
            
            Console.Read();
        }
    }

    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}