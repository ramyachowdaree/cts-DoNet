using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();

        // Create
        db.Products.Add(new Product
        {
            Name = "Laptop",
            Price = 55000
        });

        db.SaveChanges();

        Console.WriteLine("Products after Insert:");

        // Read
        foreach (var product in db.Products)
        {
            Console.WriteLine($"{product.ProductId} {product.Name} {product.Price}");
        }

        // Update
        var item = db.Products.First();

        item.Price = 60000;

        db.SaveChanges();

        Console.WriteLine("Product Updated.");

        // Delete
        db.Products.Remove(item);

        db.SaveChanges();

        Console.WriteLine("Product Deleted.");
    }
}