using System;

namespace CsLab2
{
    internal class Assiment7
    {
        public void Attendance()
        {
            int[] attendance = new int[5];
            int totalDaysAttended = 0;

            for (int i = 0; i < attendance.Length; i++)
            {
                Console.Write($"Enter attendance for day {i + 1} (1 for present, 0 for absent): ");
                attendance[i] = Convert.ToInt32(Console.ReadLine());

                if (attendance[i] != 0 && attendance[i] != 1)
                {
                    Console.WriteLine("Enter a valid input (0 or 1).");
                    i--; 
                    continue;
                }

                totalDaysAttended += attendance[i];
            }

            Console.WriteLine($"Total days attended: {totalDaysAttended}");
            if (totalDaysAttended == 5)
            {
                Console.WriteLine("Perfect attendance!");
            }
            else
            {
                Console.WriteLine("No perfect attendance.");
            }
        }
    }
}
