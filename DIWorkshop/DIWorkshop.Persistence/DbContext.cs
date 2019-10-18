using DIWorkshop.Entities;
using System.Collections.Generic;

namespace DIWorkshop.Persistence
{
    public class DbContext
    {
        public readonly List<Car> Cars;

        public readonly List<Driver> Drivers;

        public DbContext()
        {
            Cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Manufacturer = "Audi",
                    Model = "100",
                    Year = 1991
                },
                new Car
                {
                    Id = 2,
                    Manufacturer = "Audi",
                    Model = "A6",
                    Year = 1994
                },
                new Car
                {
                    Id = 3,
                    Manufacturer = "Ford",
                    Model = "Fiesta",
                    Year = 2010
                }
            };

            Drivers = new List<Driver>
            {
                new Driver
                {
                    Id = 1,
                    Firstname = "Chris",
                    Lastname = "Nrs"
                },
                new Driver
                {
                    Id = 2,
                    Firstname = "John",
                    Lastname = "Johnson"
                }
            };
        }
    }
}