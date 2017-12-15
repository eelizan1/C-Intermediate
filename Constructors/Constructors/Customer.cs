using System.Collections.Generic;

namespace Constructors
{
    public class Order
    {

    }
    public class Customer
    {
        public int Id; 
        public string Name;
        // list of orders
        public List<Order> Orders; 

        // defualt constructor 
        public Customer()
        {
            // intialize to an empty list
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // calls the constructor without parameters - grabs the empty list
        {
            this.Id = id; 
        }
        public Customer(int id, string name)
            : this(id) // calls the constructor without parameters - grabs the empty list
        {
            this.Id = id;
            this.Name = name;
        }
    }
}