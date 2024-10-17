using System;

namespace ass3
{
    internal class Program
    {
        public class BankAccount
        {
            public string AccountHolder { get; set; }
            private decimal Balance { get; set; }

            public BankAccount(string accountHolder)
            {
                AccountHolder = accountHolder;
                Balance = 0;
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Deposit amount must be positive.");
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                    throw new InvalidOperationException("Insufficient funds for this withdrawal.");
                if (amount <= 0)
                    throw new ArgumentException("Withdrawal amount must be positive.");
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
            }
        }

        // 2. Student Grade Calculation Program
        public class GradeCalculator
        {
            public static void Calculate()
            {
                double[] marks = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter marks for subject {i + 1}: ");
                    double mark;
                    if (!double.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");
                    }
                    marks[i] = mark;
                }

                double average = CalculateAverage(marks);
                Console.WriteLine($"Average Marks: {average}");
                Console.WriteLine($"Grade: {AssignGrade(average)}");
            }

            private static double CalculateAverage(double[] marks)
            {
                double total = 0;
                foreach (var mark in marks) total += mark;
                return total / marks.Length;
            }

            private static char AssignGrade(double average)
            {
                if (average >= 90) return 'A';
                else if (average >= 80) return 'B';
                else if (average >= 70) return 'C';
                else if (average >= 60) return 'D';
                return 'F';
            }
        }

        // 3. Temperature Conversion Program
        public class TemperatureConverter
        {
            public void Convert()
            {
                while (true)
                {
                    Console.Write("Enter 'C' for Celsius to Fahrenheit or 'F' for Fahrenheit to Celsius (or 'exit' to quit): ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "exit") break;

                    if (choice == "c")
                    {
                        Console.Write("Enter temperature in Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out double celsius))
                        {
                            double fahrenheit = (celsius * 9 / 5) + 32;
                            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                        }
                    }
                    else if (choice == "f")
                    {
                        Console.Write("Enter temperature in Fahrenheit: ");
                        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                        {
                            double celsius = (fahrenheit - 32) * 5 / 9;
                            Console.WriteLine($"Temperature in Celsius: {celsius}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }
        }

        // 4. Employee Management System
        public class Employee
        {
            public string Name { get; set; }
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Age must be positive.");
                    age = value;
                }
            }
            private decimal salary;
            public string Department { get; set; }

            public decimal Salary
            {
                get { return salary; }
                private set { salary = value; }
            }

            public Employee(string name, int age, decimal salary, string department)
            {
                Name = name;
                Age = age;
                Salary = salary;
                Department = department;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}, Department: {Department}");
            }
        }

        // 5. Simple Calculator Program
        public class SimpleCalculator
        {
            public static void Calculate()
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                try
                {
                    double result = operation switch
                    {
                        '+' => num1 + num2,
                        '-' => num1 - num2,
                        '*' => num1 * num2,
                        '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
                        _ => throw new InvalidOperationException("Invalid operation.")
                    };
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // 6. Library Management System
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int CopiesAvailable { get; set; }

            public void IssueBook()
            {
                if (CopiesAvailable <= 0)
                    throw new InvalidOperationException("No copies available for issuing.");
                CopiesAvailable--;
                Console.WriteLine($"Book '{Title}' issued. Copies left: {CopiesAvailable}");
            }

            public void ReturnBook()
            {
                CopiesAvailable++;
                Console.WriteLine($"Book '{Title}' returned. Copies available: {CopiesAvailable}");
            }
        }

        // 7. Prime Number Checker
        public class PrimeChecker
        {
            public static void Check()
            {
                Console.Write("Enter a positive integer: ");
                if (!int.TryParse(Console.ReadLine(), out int number) || number <= 1)
                {
                    throw new ArgumentException("Number must be greater than 1.");
                }

                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} is {(isPrime ? "a prime number." : "not a prime number.")}");
            }
        }

        // 8. Car Rental System
        public class Car
        {
            public string Model { get; set; }
            public decimal DailyRate { get; set; }
            public bool IsAvailable { get; set; }

            public Car(string model, decimal dailyRate)
            {
                Model = model;
                DailyRate = dailyRate;
                IsAvailable = true;
            }

            public decimal Rent(int days)
            {
                if (!IsAvailable)
                    throw new InvalidOperationException("Car is not available for rent.");
                IsAvailable = false;
                return DailyRate * days;
            }

            public void ReturnCar()
            {
                IsAvailable = true;
                Console.WriteLine($"Car {Model} returned and is now available.");
            }
        }

        // 9. E-commerce Order Management System
        public class Order
        {
            public string OrderID { get; set; }
            public string CustomerName { get; set; }
            private decimal amount;
            public string OrderStatus { get; set; }

            public decimal Amount
            {
                get { return amount; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Amount cannot be negative.");
                    amount = value;
                }
            }

            public void UpdateStatus(string status)
            {
                OrderStatus = status;
                Console.WriteLine($"Order {OrderID} status updated to: {OrderStatus}");
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Order ID: {OrderID}, Customer: {CustomerName}, Amount: {Amount}, Status: {OrderStatus}");
            }
        }

        // Main Program
        static void Main(string[] args)
        {
            // Uncomment the system you want to test
            TestBankAccount();
            GradeCalculator.Calculate();
            TestTemperatureConverter();
            TestEmployeeManagement();
            SimpleCalculator.Calculate();
            TestLibraryManagement();
            PrimeChecker.Check();
            TestCarRental();
            TestOrderManagement();
        }

        static void TestBankAccount()
        {
            var account = new BankAccount("John Doe");
            account.Deposit(100);
            account.Withdraw(50);
            // Uncomment to test withdrawal failure
            // account.Withdraw(100);
        }

        static void TestTemperatureConverter()
        {
            var converter = new TemperatureConverter();
            converter.Convert();
        }

        static void TestEmployeeManagement()
        {
            var employee = new Employee("Alice", 30, 50000, "HR");
            employee.DisplayInfo();
        }

        static void TestLibraryManagement()
        {
            var book = new Book { Title = "1984", Author = "George Orwell", ISBN = "123456", CopiesAvailable = 5 };
            book.IssueBook();
            book.ReturnBook();
        }

        static void TestCarRental()
        {
            var car = new Car("Toyota Camry", 50);
            try
            {
                decimal cost = car.Rent(3);
                Console.WriteLine($"Total rental cost: {cost}");
                car.ReturnCar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void TestOrderManagement()
        {
            var order = new Order { OrderID = "ORD001", CustomerName = "Bob", Amount = 150.00m, OrderStatus = "Placed" };
            order.DisplayDetails();
            order.UpdateStatus("Shipped");
        }
    }
}
