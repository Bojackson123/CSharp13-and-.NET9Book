using Microsoft.EntityFrameworkCore; // To use DbContext and so on.
// To use RelationalEventID.
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Northwind.EntityModels;

// This manages interactions with the Northwind database.
public class NorthwindDb : DbContext
{
    // These two properties map to table in the database.
    public DbSet<Category>? Categories {get; set;}
    public DbSet<Product>? Products {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(
            Environment.CurrentDirectory, databaseFile);

        string connectionString = $"Data Source={path}";
        Console.WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);
        optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuting }) // This is the Console method.
        #if DEBUG
            .EnableSensitiveDataLogging() // Include SQL parameters.
            .EnableDetailedErrors()

        #endif
        ;

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example of using Fluent API instead of attributes 
        // to limit the length of a category name to 15.
        modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired() // NotNull
            .HasMaxLength(15);

        // Some SQLite-specific configuration.
        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            // To "fix" the lack of decimal support in SQLite.
            modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
        }
    }
}