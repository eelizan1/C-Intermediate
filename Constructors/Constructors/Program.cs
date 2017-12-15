using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            // new order 
            var order = new Order();
            customer.Orders.Add(order);
            Console.Read();
        }
    }
}