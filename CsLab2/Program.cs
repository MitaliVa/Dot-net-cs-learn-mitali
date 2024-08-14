using System;
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
