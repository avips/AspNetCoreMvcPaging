using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp {

    public class SeedData {

        public static void SeedDatabase(DataContext context) {

            context.Database.Migrate();
            var processors = new[] { "AMD Ryzen 5 3500U", "AMD Ryzen 5 5600x", "Intel Core i5 10400", 
                                     "Intel Core i5 10600", "AMD Ryzen 9 5900x" };
            if (context.Products.Count() == 0) {
                for (var i = 1; i < 100; i++)
                {
                    context.Products.Add(
                    new Product
                    {
                        Name = $"Ноутбук {i}",
                        Description = $"Экран 15.6 1920х1080; TN; Процессор {processors[i % 5]}",
                        Category = "Ноутбук",
                        Price = 40000 + i * 100
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
