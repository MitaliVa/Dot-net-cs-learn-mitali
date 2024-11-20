using System;
using static ass5.Class1.Car;
using static ass5.Class1;

public class OuterClass
{
    public string OuterProperty { get; set; }

    public OuterClass(string outerProperty)
    {
        OuterProperty = outerProperty;
    }

    public class NestedClass
    {
        public string NestedProperty { get; set; }

        public NestedClass(string nestedProperty)
        {
            NestedProperty = nestedProperty;
        }

        public void Display()
        {
            Console.WriteLine($"Nested Property: {NestedProperty}");
        }
    }

    public void DisplayOuterProperty()
    {
        Console.WriteLine($"Outer Property: {OuterProperty}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
       /* OuterClass outer = new OuterClass("Outer Value");
        OuterClass.NestedClass nested = new OuterClass.NestedClass("Nested Value");
        outer.DisplayOuterProperty();
        nested.Display();*/


        Car myCar = new Car();
        BookingNotify notify = myCar.NotifyBilling;
        notify("Your booking has been confirmed.");
        Console.ReadLine();
    }
}
