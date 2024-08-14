using System;

namespace CsLab2
{
    internal class Assiment9
    {
        public void Cart()
        {
            string[,] cart = new string[10, 2]; 
            int itemCount = 0;

            while (true)
            {
                Console.WriteLine("\n1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View Total Price");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (itemCount < cart.GetLength(0))
                        {
                            Console.Write("Enter item name: ");
                            string itemName = Console.ReadLine();
                            Console.Write("Enter item price: ");
                            string itemPrice = Console.ReadLine();

                            cart[itemCount, 0] = itemName;
                            cart[itemCount, 1] = itemPrice;
                            itemCount++;
                            Console.WriteLine($"{itemName} added to the cart.");
                        }
                        else
                        {
                            Console.WriteLine("Cart is full.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter the name of the item to remove: ");
                        string removeItem = Console.ReadLine();
                        bool itemFound = false;

                        for (int i = 0; i < itemCount; i++)
                        {
                            if (cart[i, 0] == removeItem)
                            {
                                cart[i, 0] = null;
                                cart[i, 1] = null;
                                itemFound = true;
                                Console.WriteLine($"{removeItem} removed from the cart.");
                                break;
                            }
                        }

                        if (!itemFound)
                        {
                            Console.WriteLine("Item not found in the cart.");
                        }
                        break;

                    case 3:
                        double totalPrice = 0;

                        Console.WriteLine("\nItems in the cart:");
                        for (int i = 0; i < itemCount; i++)
                        {
                            if (cart[i, 0] != null)
                            {
                                Console.WriteLine($"{cart[i, 0]}: ${cart[i, 1]}");
                                totalPrice += double.Parse(cart[i, 1]);
                            }
                        }
                        Console.WriteLine($"Total Price: ${totalPrice}");
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
