using System.ComponentModel.DataAnnotations.Schema; // To use [Column].

namespace Northwind.EntityModels;

public class Category
{
    // These properties map to columns in the database.
    public int categoryId {get; set;} // The primary key.

    public string CategoryName {get; set;} = null!;

    [Column(TypeName = "ntext")]
    public string? Description {get; set;}

    // Define a navigation property for related rows.
    public virtual ICollection<Product> Products {get; set;}
        // To enable devlopers to add products to a Category, we must
        // initialize the navigation property to an empty collection.
        // This also avoids and exception if we get a member like Count.
        = new HashSet<Product>();

    
}