using System;
using Amazon; 

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var goldCustomer = new GoldCustomer();
            //Console.Write(goldCustomer.OfferVoucher());
            var customer = new Customer();
            
            Console.Read();
        }
    }

    // derives from Customer class
    //public class GoldCustomer : Customer
    //{
    //    public int OfferVoucher()
    //    {
    //        var rating = this.CalculateRating(excludeOrders: true);
    //        return rating; 
    //    }
    //}
}
