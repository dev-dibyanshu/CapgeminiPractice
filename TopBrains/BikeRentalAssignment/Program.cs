using System;
using System.Collections.Generic;

class Program
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice: ");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid Choice. Enter Again: ");
            }

            switch (choice)
            {
                case 1:

                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day: ");

                    int price;

                    while (!int.TryParse(Console.ReadLine(), out price))
                    {
                        Console.Write("Invalid Price. Enter Again: ");
                    }

                    utility.AddBikeDetails(model, brand, price);

                    Console.WriteLine();
                    Console.WriteLine("Bike details added successfully");

                    break;

                case 2:

                    SortedDictionary<string, List<Bike>> bikes =
                        utility.GroupBikesByBrand();

                    Console.WriteLine();

                    foreach (KeyValuePair<string, List<Bike>> group in bikes)
                    {
                        foreach (Bike bike in group.Value)
                        {
                            Console.WriteLine($"{group.Key} {bike.Model}");
                        }
                    }

                    break;

                case 3:

                    return;

                default:

                    Console.WriteLine("Invalid Choice");

                    break;
            }
        }
    }
}