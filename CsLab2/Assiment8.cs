using System;

namespace CsLab2
{
    internal class Assiment8
    {
        public void Expenses()
        {
            double[] expenses = new double[12];
            double totalExpenses = 0;
            double highestExpense = double.MinValue;
            double lowestExpense = double.MaxValue;
            int highestMonth = -1;
            int lowestMonth = -1;

            for (int i = 0; i < expenses.Length; i++)
            {
                Console.Write($"Enter expenses for month {i + 1}: Rs. ");
                expenses[i] = Convert.ToDouble(Console.ReadLine());
                totalExpenses += expenses[i];

                if (expenses[i] > highestExpense)
                {
                    highestExpense = expenses[i];
                    highestMonth = i;
                }

                if (expenses[i] < lowestExpense)
                {
                    lowestExpense = expenses[i];
                    lowestMonth = i;
                }
            }

            Console.WriteLine($"Total expenses for the year: Rs. {totalExpenses}");
            Console.WriteLine($"Month with highest expenses: {highestMonth + 1} (Rs. {highestExpense})");
            Console.WriteLine($"Month with lowest expenses: {lowestMonth + 1} (Rs. {lowestExpense})");
        }
    }
}
