namespace Methods
{
    // 1. Signaure of a Method
    //      - Name
    //      - Number and Type of parameters 
    //
    // 2. Overloading Methods 
    //      - Having a method with the same name but different signatures 
    //
    // 3. Params modifier 
    //      Allows you to reduce the number of methods being overloaded
    //      Can pass a varying number of arguments

    public class Calculator
    {
        // params allows the user to input as many numbers as possible AND array objects
        public int Add(params int[] numbers)
        {
            // add all numbers in the array and return the result
            var sum = 0; 
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}