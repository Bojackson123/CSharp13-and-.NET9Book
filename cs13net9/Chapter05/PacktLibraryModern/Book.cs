using System.Diagnostics.CodeAnalysis; // To use [SetRequiredMembers].
namespace PacktModern.Shared;

public class Book
{
  // Needs .NET 7 or Later as well as c# 11 or later.
  public required string? Isbn;
  public required string? Title;

  // Works with any version of .NET.
  public string? Author;
  public int PageCount;

  // Constructor with parameters to set required fields.
  public Book() {}

  // Constructor with parameters to set required fields.
  [SetsRequiredMembers]
  public Book(string? isbn, string? title)
  {
    Isbn = isbn;
    Title = title;
  }
}
