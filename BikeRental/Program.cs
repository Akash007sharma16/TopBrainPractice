
using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public int PricePerDay { get; set; }
    public string Brand { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int nextKey = Program.bikeDetails.Count + 1;

        Bike newBike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        Program.bikeDetails.Add(nextKey, newBike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes =
            new SortedDictionary<string, List<Bike>>();

        foreach (var bikeEntry in Program.bikeDetails)
        {
            Bike bike = bikeEntry.Value;

            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }

            groupedBikes[bike.Brand].Add(bike);
        }

        return groupedBikes;
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();
        int choice = 0;

        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\nEnter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nEnter the model:");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the brand:");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day:");
                int price = Convert.ToInt32(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);

                Console.WriteLine("\nBike details added successfully\n");
            }
            else if (choice == 2)
            {
                SortedDictionary<string, List<Bike>> result =
                    utility.GroupBikesByBrand();

                foreach (var brandEntry in result)
                {
                    foreach (Bike bike in brandEntry.Value)
                    {
                        Console.WriteLine($"{brandEntry.Key} {bike.Model}");
                    }
                }

                Console.WriteLine();
            }
            else if (choice == 3)
            {
                break;
            }

        } while (choice != 3);
    }
}
