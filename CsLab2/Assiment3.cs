using System;

namespace CsLab2
{
    internal class Assiment3
    {

        public void Bank()
        {
            double balance = 1000;
            int choice;

            do
            {
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: Rs. {balance}");
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: Rs. ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("Deposit successful.");
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: Rs. ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal successful.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 4);
        }


    }
}
