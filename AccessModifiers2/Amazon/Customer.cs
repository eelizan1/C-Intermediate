using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            // passes 'this' as the customer object to the method
            var rating = calculator.Calculate(this);
        }
    }

    // declared internal so it is not viewable outside Amazon
    // used only for Customer class 
    internal class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0; 
        }
    }
}
