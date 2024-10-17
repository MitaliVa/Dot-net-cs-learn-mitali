using System;

namespace ass4
{
    internal class Storage<T>
    {
        public T Item { get; set; }

        public Storage(T item)
        {
            Item = item;
        }
    }

    internal class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void PrintPair()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }
    internal class Calulater<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Calulater(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void addition()
        {
            dynamic a = First;
            dynamic b = Second;
            Console.WriteLine($"Addition result: {a + b}");
        }

        public void subtraction()
        {
            dynamic a = First;
            dynamic b = Second;
            Console.WriteLine($"Subtraction result: {a - b}");
        }

        public void multiplication()
        {
            dynamic a = First;
            dynamic b = Second;
            Console.WriteLine($"Multiplication result: {a * b}");
        }

        public void division()
        {
            dynamic a = First;
            dynamic b = Second;
            if (b != 0)
            {
                Console.WriteLine($"Division result: {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<int> intStorage = new Storage<int>(42);
            Console.WriteLine($"Stored integer: {intStorage.Item}");

            Storage<string> stringStorage = new Storage<string>("Hello, Generics!");
            Console.WriteLine($"Stored string: {stringStorage.Item}");

            Storage<double> doubleStorage = new Storage<double>(3.14);
            Console.WriteLine($"Stored double: {doubleStorage.Item}");

            Console.WriteLine(); 

            Pair<int, string> pair1 = new Pair<int, string>(1, "One");
            pair1.PrintPair();

            Pair<string, double> pair2 = new Pair<string, double>("Pi", 3.14);
            pair2.PrintPair();

            Pair<bool, char> pair3 = new Pair<bool, char>(true, 'A');
            pair3.PrintPair();



            Console.Write("Enter the first number (int): ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number (double): ");
            double secondNumber = double.Parse(Console.ReadLine());
            Calulater<int, double> calculator1 = new Calulater<int, double>(firstNumber, secondNumber);
            calculator1.addition();
            calculator1.subtraction();
            calculator1.multiplication();
            calculator1.division();



            Console.ReadLine(); 
        }
    }
}
