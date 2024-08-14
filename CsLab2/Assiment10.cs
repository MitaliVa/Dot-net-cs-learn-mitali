using System;

namespace CsLab2
{
    internal class Assiment10
    {
        public void Work()
        {
            Console.Write("Enter hourly wage: Rs. ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked per week: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            double weeklySalary = hourlyWage * hoursWorked;
            double monthlySalary = weeklySalary * 4; // 4 weeks in a month

            Console.WriteLine($"Monthly salary: Rs. {monthlySalary}");
        }
    }
}
