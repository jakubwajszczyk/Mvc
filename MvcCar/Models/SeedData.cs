using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using System;
using System.Linq;
namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                if (context.Car.Any())
                {
                    return;  
                }
                context.Car.AddRange(
                    new Car
                    {
                        Mark = "Audi",
                        Model = "A8",
                        YearOfProduction = DateTime.Parse("2020-2-17"),
                        Price = 320000
                    },
                    new Car
                    {
                        Mark = "Volkswagen",
                        Model = "Passat",
                        YearOfProduction = DateTime.Parse("2005-7-5"),
                        Price = 7500
                    },
                    new Car
                    {
                        Mark = "BMW",
                        Model = "X5",
                        YearOfProduction = DateTime.Parse("2019-10-21"),
                        Price = 450000
                    },
                    new Car
                    {
                        Mark = "Mercedes",
                        Model = "C63",
                        YearOfProduction = DateTime.Parse("2015-1-11"),
                        Price = 150000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
