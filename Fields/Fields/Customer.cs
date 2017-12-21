using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        // initialize fully here so constructors can use
        public readonly List<Order> Orders = new List<Order>(); // uses Order class

        // constructors 
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // uses previous constructor
        {
            this.Name = name;
        }

        // read only modifier 
        public void Promote()
        {
            // if you reinitialize, the original orders field will be lost
            // so use read only modifier
            //Orders = new List<Order>();
            
            // .... 
        }
    }
}