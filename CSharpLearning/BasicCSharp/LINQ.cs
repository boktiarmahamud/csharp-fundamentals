using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCSharp
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Rating { get; set; }
    }

    internal class LINQ
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product
            {
                Id = 1,
                Name = "Dell Laptop",
                Category = "Laptop",
                Price = 120000,
                Stock = 2,
                Rating = 4.5
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "HP Laptop",
                Category = "Laptop",
                Price = 100000,
                Stock = 20,
                Rating = 4.2
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "IPad",
                Category = "Tablet",
                Price = 13000,
                Stock = 4,
                Rating = 4.0
            });

            products.Add(new Product
            {
                Id = 4,
                Name = "Headphones",
                Category = "Electronics",
                Price = 15000,
                Stock = 30,
                Rating = 4.3
            });

            products.Add(new Product
            {
                Id = 5,
                Name = "IPhone",
                Category = "Mobile",
                Price = 25000,
                Stock = 5,
                Rating = 4.1
            });

            // LINQ: Get products where Price is greater than 14000
            var res = products
                .Where(p => p.Price > 14000)
                .ToList();

            // Display the result
            Console.WriteLine("Using where filter Products with Price greater than 14000:");
            foreach (var product in res)
            {
                Console.WriteLine(
                    $"Id: {product.Id}, " +
                    $"Name: {product.Name}, " +
                    $"Category: {product.Category}, " +
                    $"Price: {product.Price}, " +
                    $"Stock: {product.Stock}, " +
                    $"Rating: {product.Rating}"
                );
            }

            var name = products.Select(p => p.Name).ToList();
            Console.WriteLine("Using select Product Names:");
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }

            // sort products by price
            Console.WriteLine("Using orderby sort Products by Price:");
            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(
                    $"Id: {product.Id}, " +
                    $"Name: {product.Name}, " +
                    $"Category: {product.Category}, " +
                    $"Price: {product.Price}, " +
                    $"Stock: {product.Stock}, " +
                    $"Rating: {product.Rating}"
                );
            }

            // group products by category
            var group = products.GroupBy(p => p.Category);
            Console.WriteLine("Using groupby group Products by Category:");
            foreach (var g in group)
            {
                Console.WriteLine($"Category: {g.Key}");
                foreach (var product in g)
                {
                    Console.WriteLine(
                        $"Id: {product.Id}, " +
                        $"Name: {product.Name}, " +
                        $"Category: {product.Category}, " +
                        $"Price: {product.Price}, " +
                        $"Stock: {product.Stock}, " +
                        $"Rating: {product.Rating}"
                    );
                }
            }

            // Any()
            var exist = products.Any(p => p.Price > 200000);
            Console.WriteLine("If any product has price greater than 200000: " + exist);

            // All()

            var allInStock = products.All(p => p.Stock > 0);
            Console.WriteLine("If all products are in stock: " + allInStock);

            // First()

            var FirstProduct = products.First();
            Console.WriteLine("First Product: " + FirstProduct.Name);

            // FirstOrDefault()

            var FirstOrDefaultProduct = products.FirstOrDefault(p => p.Price > 200000);
            if (FirstOrDefaultProduct != null)
            {
                Console.WriteLine("FirstOrDefault Product: " + FirstOrDefaultProduct.Name);
            }
            else
            {
                Console.WriteLine("No product found with price greater than 200000.");
            }

            // combine all the LINQ methods together
            var combinedResult = products
                .Where(p => p.Category == "Laptop")
                .Where(p => p.Stock > 0 && p.Price > 20000)
                .OrderByDescending(p => p.Rating)
                .Take(3)
                .Select(p => new { p.Name, p.Price, p.Rating })
                .ToList();

            foreach (var product in combinedResult)
            {
                Console.WriteLine($"Product name: {product.Name}, price: {product.Price}, Rating: {product.Rating}");
            }
            Console.ReadLine();
        }
    }
}