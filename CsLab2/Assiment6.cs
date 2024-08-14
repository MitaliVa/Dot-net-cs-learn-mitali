using System;

namespace CsLab2
{
    internal class Assiment6
    {
        public void Distance()
        {
            Console.Write("Enter distance traveled (in kilometers): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fare = 20; 

            if (distance > 2)
            {
                fare += (distance - 2) * 10; 
            }

            Console.Write("Enter the time of the ride (24-hour format, e.g., 23 for 11 PM): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour >= 22)
            {
                fare += 50; 
            }

            Console.WriteLine($"Total fare: Rs. {fare}");
        }
    }
}
