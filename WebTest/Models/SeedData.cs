using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data;

namespace WebTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                // Look for any Cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Make = "Toyota",
                        ReleaseDate = DateTime.Parse("1992-1-1"),
                        Model = "Supra",
                        Price = 32000
                    },

                    new Car
                    {
                        Make = "Honda",
                        ReleaseDate = DateTime.Parse("1994-1-1"),
                        Model = "NSX",
                        Price = 40000
                    },

                    new Car
                    {
                        Make = "Porsche",
                        ReleaseDate = DateTime.Parse("1992-1-1"),
                        Model = "911 Turbo",
                        Price = 50000
                    },

                    new Car
                    {
                        Make = "Mazda",
                        ReleaseDate = DateTime.Parse("1994-1-1"),
                        Model = "RX-7",
                        Price = 35000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
