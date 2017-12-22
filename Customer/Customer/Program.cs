using System;
using System.Collections.Generic;

// Default or parameterless constructor 
// note: if you dont define a default or parameterless constructor
// c# compiler creates on for it 
// It will initialize the fields of the class to their default values
        // Default Values: 
        // numbers set to 0
        // boolean set to false 
        // References types (strings, objects) sets to Null
        // char sets to an empty char 

// Constructor Overloading - Having the same name but different signatures
namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Enrico");
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);
            customer.Orders.Add(order);

            Console.Read();
        }
    }

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; 
        // rule of thumb: initialize a list of objects to an empty list

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // calls constructor without parameters
        {
            this.Id = id; 
            // Orders has to be initialized here, 
            // otherwise it will be a null reference
            //Orders = new List<Order>();
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name; 
        }
    }
}
