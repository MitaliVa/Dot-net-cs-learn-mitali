using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass5
{
    internal class Class1
    {
        public class Car
        {
            public delegate void BookingNotify(String message);
            public void NotifyBilling(string message)
            {
                Console.WriteLine("Billing Department :" + message);
            }
        }
    }
}
