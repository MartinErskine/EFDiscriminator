using EFDiscriminator.Domain;
using EFDiscriminator.Seed;
using System;
using System.Collections.Generic;

namespace EFDiscriminator
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new HashSet<ConfiguredLaptop>();

            var data = new ConfiguredLaptops();

            data.Initialise();

            basket.Add(data.ConfiguredLaptop);

            AddItemToBasket(basket, data.ConfiguredLaptopSame);
            AddItemToBasket(basket, data.ConfiguredLaptopDifferent);

            foreach (var item in basket)
            {
                Console.WriteLine($"Laptop: {item.Laptop.Name}");

                foreach (var configurationItem in item.ConfigurationItems)
                {
                    Console.WriteLine($" - {configurationItem.ConfigurationName} {configurationItem.Name} {configurationItem.Price}");
                }
            }

            Console.ReadLine();
        }

        private static void AddItemToBasket(HashSet<ConfiguredLaptop> basket, ConfiguredLaptop configuredLaptop)
        {
            var itemAlreadyAdded = false;

            foreach (var item in basket)
            {
                if (item.Equals(configuredLaptop))
                {
                    itemAlreadyAdded = true;
                }
            }

            if (!itemAlreadyAdded)
            {
                basket.Add(configuredLaptop);
            }
        }
    }
}

