using System;
using System.Linq;
using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore; // To use Include method
using Northwind.EntityModels;

partial class Program
{
    private static void QueryingCategories()
    {
        using NorthwindDb db = new();

        SectionTitle("Categories and how many products they have");

        // A query to get all categories and their relate products.
        // This is a query definition. Nothing has executed against
        // the database
        IQueryable<Category>? categories = db.Categories?
            .Include(c => c.Products);

        // You could call any of the following LINQ methods and nothing will be executed against the database:
        // Where, GroupBy, Select, SelectMany, OfType, OrderBy, ThenBy, Join, GroupJoin, Take, Skip, Reverse.
        // Usually, methods that return IEnumerable or IQueryable support deferred execution.
        // Usually, methods that return a single value do not support deferred execution.

        if (categories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }

        // Enumerating the query converts it to SQL and executes it against the database.
        // Execute query and enumerate results.
        foreach (Category c in categories)
        {
            Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
        }
    }

    private static void FilteredIncludes()
    {
        using NorthwindDb db = new();

        SectionTitle("Products with a minimum number of units in stock");

        string? input;
        int stock;

        do
        {
            Console.Write("Enter a minimum for units in stock: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out stock));

        IQueryable<Category>? categories = db.Categories?
            .Include(c => c.Products.Where(p => p.Stock >= stock));

        if (categories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }

        foreach (Category c in categories)
        {
            Console.WriteLine("{0} has {1} products with a minimum {2} units in stock",
                arg0: c.CategoryName, arg1: c.Products.Count, arg2: stock);

            foreach (Product p in c.Products)
            {
                Console.WriteLine($" {p.ProductName} has {p.Stock} units in stock.");
            }
        }
    }

    private static void QueryingProducts()
    {
        using NorthwindDb db = new();

        SectionTitle("Products that cost more than a price, highest at top");

        string? input;
        decimal price;

        do
        {
            Console.Write("Enter a product price: ");
            input = Console.ReadLine();
        } while (!decimal.TryParse(input, out price));

        IQueryable<Product>? products = db.Products?
            .Where(product => product.Cost > price)
            .OrderByDescending(product => product.Cost);

        if (products is null || !products.Any())
        {
            Fail("No products found.");
        }

        // Calling ToQueryString does not execute against the database.
        // LINQ to Entities just converts the LINQ query to an SQL statement.
        Info($"ToQueryString: {products.ToQueryString()}");

        foreach (Product p in products)
        {
            Console.WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock.",
                p.ProductId, p.ProductName, p.Cost, p.Stock);
        }
    }

    private static void GettingOneProduct()
    {
        using NorthwindDb db = new();

        SectionTitle("Getting a single product");

        string? input;
        int id;

        do
        {
            Console.Write("Enter a product ID: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out id));

        // This query is not deferred because the First method does not return IEnumerable or IQueryable.
        // The LINQ query is immediately converted to SQL and executed to fetch the first product.
        Product? product = db.Products?
            .First(product => product.ProductId == id);

        Info($"First: {product?.ProductName}");

        if (product is null) Fail("No product found using First.");

        product = db.Products?
            .Single(product => product.ProductId == id);

        Info($"Single: {product?.ProductName}");

        if (product is null) Fail("No product found using Single.");
    }
}