using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp {

    public class SeedData {

        public static void SeedDatabase(DataContext context) {

            context.Database.Migrate();

            if (context.Products.Count() == 0) {
                for (var i = 1; i < 100; i++)
                {
                    context.Products.Add(
                    new Product
                    {
                        Name = $"Ноутбук {i}",
                        Description = @"Экран 15.6 1920х1080; TN; Процессор AMD Ryzen 5 3500U 2.1ГГц;",
                        Category = "Ноутбук",
                        Price = 40000
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
