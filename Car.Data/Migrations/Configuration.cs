namespace Car.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Car.Data;
    


    internal sealed class Configuration : DbMigrationsConfiguration<Car.Data.CarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Car.Data.CarDbContext";
        }

        protected override void Seed(Car.Data.CarDbContext context)
        {
            context.Cars.AddOrUpdate(
                c => c.Brand,
                new Entities.Car { Brand="Porsche", Model="911 Turbo", Year=1986},
                new Entities.Car { Brand = "BMW", Model = "M5", Year = 2003 },
                new Entities.Car { Brand = "Audi", Model = "R8", Year = 2016 },
                new Entities.Car { Brand = "Lamborghini", Model = "Huracan", Year = 1997 },
                new Entities.Car { Brand = "Ferrari", Model = "488 GTB", Year = 2013 },
                new Entities.Car { Brand = "Aston Martin", Model = "DB11", Year = 2017 }
                );
        }
    }
}
