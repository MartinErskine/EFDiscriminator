using EFDiscriminator.Domain;
using EFDiscriminator.Enums;
using System;
using System.Collections.Generic;

namespace EFDiscriminator.Seed
{
    public class ConfiguredLaptops
    {
        public  ConfiguredLaptop ConfiguredLaptop { get; set; }
        public  ConfiguredLaptop ConfiguredLaptopSame { get; set; }
        public  ConfiguredLaptop ConfiguredLaptopDifferent { get; set; }


        public void Initialise()
        {
            ConfiguredLaptop = new ConfiguredLaptop
            {
                Laptop = new Laptop
                {
                    Id = new Guid("a99a8e22-52f7-4f53-b443-ec2519cd34df"),
                    Name = "DELL XPS 13",
                    Price = 350.00M
                },

                ConfigurationItems = new HashSet<ConfigurationItem>
                {
                    new Colour
                    {
                        Id = new Guid("34ee3871-7b6f-464a-ba3e-3dd3197ca69e"),
                        ConfigurationName = ConfigurationItemName.Colour,
                        Name = "Red",
                        Price = 30.00M
                    },
                    new Ram
                    {
                        Id = new Guid("6912564b-5052-47b2-8e2d-f90e5e556556"),
                        ConfigurationName = ConfigurationItemName.Ram,
                        Name = "1GB",
                        Price = 65.00M
                    },
                    new Storage
                    {
                        ConfigurationName = ConfigurationItemName.Storage,
                        Id = new Guid("ea634923-7e35-449d-8c8b-1d7b17865a9b"),
                        Name = "256GB SSD",
                        Price = 120.00M
                    }
                }
            };

            ConfiguredLaptopSame = new ConfiguredLaptop
            {
                Laptop = new Laptop
                {
                    Id = new Guid("a99a8e22-52f7-4f53-b443-ec2519cd34df"),
                    Name = "DELL XPS 13",
                    Price = 350.00M
                },

                ConfigurationItems = new HashSet<ConfigurationItem>
                {
                    new Colour
                    {
                        Id = new Guid("34ee3871-7b6f-464a-ba3e-3dd3197ca69e"),
                        ConfigurationName = ConfigurationItemName.Colour,
                        Name = "Red",
                        Price = 30.00M
                    },
                    new Ram
                    {
                        Id = new Guid("6912564b-5052-47b2-8e2d-f90e5e556556"),
                        ConfigurationName = ConfigurationItemName.Ram,
                        Name = "1GB",
                        Price = 65.00M
                    },

                    new Storage
                    {
                        ConfigurationName = ConfigurationItemName.Storage,
                        Id = new Guid("ea634923-7e35-449d-8c8b-1d7b17865a9b"),
                        Name = "256GB SSD",
                        Price = 120.00M
                    }
                }
            };

            ConfiguredLaptopDifferent = new ConfiguredLaptop
            {
                Laptop = new Laptop
                {
                    Id = new Guid("a99a8e22-52f7-4f53-b443-ec2519cd34df"),
                    Name = "DELL XPS 15",
                    Price = 350.00M
                },

                ConfigurationItems = new HashSet<ConfigurationItem>
                {
                    new Colour
                    {
                        Id = new Guid("34ee3871-7b6f-464a-ba3e-3dd3197ca69e"),
                        ConfigurationName = ConfigurationItemName.Colour,
                        Name = "Red",
                        Price = 30.00M
                    },
                    new Ram
                    {
                        Id = new Guid("6912564b-5052-47b2-8e2d-f90e5e556556"),
                        ConfigurationName = ConfigurationItemName.Ram,
                        Name = "1GB",
                        Price = 65.00M
                    },
                    new Storage
                    {
                        ConfigurationName = ConfigurationItemName.Storage,
                        Id = new Guid("ea634923-7e35-449d-8c8b-1d7b17865a9b"),
                        Name = "256GB SSD",
                        Price = 120.00M
                    }
                }
            };
        }
    }
}
