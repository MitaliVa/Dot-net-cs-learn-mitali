/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Discount");
            Assiment1 p1 = new Assiment1();
            p1.Discount();

            Console.WriteLine("Temp Converter");
            Assiment2 p2 = new Assiment2();
            p2.Temp();

            Console.WriteLine("Bank ATM");
            Assiment3 p3 = new Assiment3();
            p3.Bank();

            Console.WriteLine("Marks");
            Assiment4 p4 = new Assiment4();
            p4.Marks();

            Console.WriteLine("Validate Password");
            Assiment5 p5 = new Assiment5();
            p5.Password();

            Console.WriteLine("Calculate Distance");
            Assiment6 p6 = new Assiment6();
            p6.Distance();

            Console.WriteLine("Student Attendance");
            Assiment7 p7 = new Assiment7();
            p7.Attendance();

            Console.WriteLine("Calculate Expances");
            Assiment8 p8 = new Assiment8();
            p8.Expenses();

            Console.WriteLine("Cart System ");
            Assiment9 p9 = new Assiment9();
            p9.Cart();

            Console.WriteLine("Calculates the monthly salary ");
            Assiment10 p10 = new Assiment10();
            p10.Work();
            Console.ReadLine();
        }
    }
}
*/


using System;

namespace CsLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Calculate Discount");
            Console.WriteLine("2. Temp Converter");
            Console.WriteLine("3. Bank ATM");
            Console.WriteLine("4. Marks");
            Console.WriteLine("5. Validate Password");
            Console.WriteLine("6. Calculate Distance");
            Console.WriteLine("7. Student Attendance");
            Console.WriteLine("8. Calculate Expenses");
            Console.WriteLine("9. Cart System");
            Console.WriteLine("10. Calculate Monthly Salary");

            Console.Write("Enter your choice (1-10): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Calculate Discount");
                    Assiment1 p1 = new Assiment1();
                    p1.Discount();
                    break;
                case 2:
                    Console.WriteLine("Temp Converter");
                    Assiment2 p2 = new Assiment2();
                    p2.Temp();
                    break;
                case 3:
                    Console.WriteLine("Bank ATM");
                    Assiment3 p3 = new Assiment3();
                    p3.Bank();
                    break;
                case 4:
                    Console.WriteLine("Marks");
                    Assiment4 p4 = new Assiment4();
                    p4.Marks();
                    break;
                case 5:
                    Console.WriteLine("Validate Password");
                    Assiment5 p5 = new Assiment5();
                    p5.Password();
                    break;
                case 6:
                    Console.WriteLine("Calculate Distance");
                    Assiment6 p6 = new Assiment6();
                    p6.Distance();
                    break;
                case 7:
                    Console.WriteLine("Student Attendance");
                    Assiment7 p7 = new Assiment7();
                    p7.Attendance();
                    break;
                case 8:
                    Console.WriteLine("Calculate Expenses");
                    Assiment8 p8 = new Assiment8();
                    p8.Expenses();
                    break;
                case 9:
                    Console.WriteLine("Cart System");
                    Assiment9 p9 = new Assiment9();
                    p9.Cart();
                    break;
                case 10:
                    Console.WriteLine("Calculate Monthly Salary");
                    Assiment10 p10 = new Assiment10();
                    p10.Work();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 10.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
