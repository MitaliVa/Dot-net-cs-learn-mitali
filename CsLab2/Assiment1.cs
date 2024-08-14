using System;

namespace CsLab2
{
    internal class Assiment1
    {
        public void Discount() // Make this method non-static
        {
            double[] prices = { 500, 600, 700, 800, 1000 };
            double totalPrice = 0;

            foreach (double price in prices)
            {
                totalPrice += price;
            }

            if (totalPrice > 3000)
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"Total price after discount (if applicable): Rs. {totalPrice}");
        }
    }
}
