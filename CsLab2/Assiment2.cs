using System;

namespace CsLab2
{
    internal class Assiment2
    {
        public void Temp()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");

            if (celsius < 0)
            {
                Console.WriteLine("Warning: Freezing temperatures!");
            }
        }
    }
}
