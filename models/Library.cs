using System;
using System.Collections.Generic;


namespace console_library.Models
{
  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }

    private List<Book> Books { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book> { };
    }
    public void LibrarySetup()
    {
      Console.WriteLine($"Welcome to the {Location} Library!");
      Book eloquentJavaScript = new Book("Eloquent Javascript", "Marijn Haverbeke");
      Book introducingPython = new Book("Introducing Python", "Bill Lubanovic");
      Book withoutRemorse = new Book("Without Remorse", "Tom Clancy");
      Book bourneIdentity = new Book("The Bourne Identity", "Robert Ludlum");

      Books.Add(eloquentJavaScript);
      Books.Add(introducingPython);
      Books.Add(withoutRemorse);
      Books.Add(bourneIdentity);
    }

    public void PrintAvailableBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
        if (book.Available)
        {
          Console.WriteLine($"{i + 1}) {Books[i].Title} - {Books[i].Author}");
        }
      }
    }
    public void PrintReturnableBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
        if (!book.Available)
        {
          Console.WriteLine($"{i + 1}) {Books[i].Title} - {Books[i].Author}");
        }
      }
    }
    public void CheckoutBook()
    {
      PrintAvailableBooks();
      Console.WriteLine("Which book would you like to check out?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Books.Count && index - 1 > -1)
      {
        Book book = Books[index - 1];
        if (!book.Available)
        {
          Console.WriteLine("That book has already been checked out!");
        }
        else
        {
          book.Available = false;
          Console.WriteLine($"You have checked out {book.Title}");
        }
      }
      else
      {
        Console.WriteLine("Invalid Book Selection");
      }
    }
    public void ReturnBook()
    {
      PrintReturnableBooks();
      Console.WriteLine("Which book would you like to return?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Books.Count && index - 1 > -1)
      {
        Book book = Books[index - 1];
        if (book.Available)
        {
          Console.WriteLine("That book has already been returned!");
        }
        else
        {
          book.Available = true;
          Console.WriteLine($"You have returned {book.Title}");
        }
      }
      else
      {
        Console.WriteLine("Invalid Book Selection");
      }
    }
  }
}