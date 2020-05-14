using System;
using System.Collections.Generic;


namespace console_library.Models
{
  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }

    private List<ICheckout> Items { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Items = new List<ICheckout> { };
    }
    public void LibrarySetup()
    {
      Console.WriteLine($"Welcome to the {Location} Library!");
      Book jabJab = new Book("Jab Jab Jab Right Hook", "Gary Vaynerchuk");
      Book TMMO = new Book("Total Money Makeover", "Dave Ramzy");
      Book golfPerfect = new Book("Golf Is Not A Game Of Perfect", "Bob Rotella");
      Book historyUS = new Book("A Patriot's History of the United States", "Larry Schweikart");
      Magazine golfDigest = new Magazine("Golf Digest", "March 2020");

      Items.Add(jabJab);
      Items.Add(TMMO);
      Items.Add(golfPerfect);
      Items.Add(historyUS);
      Items.Add(golfDigest);
    }

    public void PrintAvailableBooks()
    {
      for (int i = 0; i < Items.Count; i++)
      {
        ICheckout item = Items[i];
        if (item.Available)
        {
          Console.WriteLine($"{i + 1}) {Items[i].Title}");
        }
      }
    }
    public void PrintReturnableBooks()
    {
      for (int i = 0; i < Items.Count; i++)
      {
        ICheckout item = Items[i];
        if (!item.Available)
        {
          Console.WriteLine($"{i + 1}) {Items[i].Title}");
        }
      }
    }
    public void CheckoutBook()
    {
      PrintAvailableBooks();
      Console.WriteLine("Which item would you like to check out?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Items.Count && index - 1 > -1)
      {
        ICheckout item = Items[index - 1];
        if (!item.Available)
        {
          Console.WriteLine("That item has already been checked out!");
        }
        else
        {
          item.Available = false;
          Console.WriteLine($"You have checked out {item.Title}");
        }
      }
      else
      {
        Console.WriteLine("Invalid Selection");
      }
    }
    public void ReturnBook()
    {
      PrintReturnableBooks();
      Console.WriteLine("Which item would you like to return?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Items.Count && index - 1 > -1)
      {
        ICheckout item = Items[index - 1];
        if (item.Available)
        {
          Console.WriteLine("That item has already been returned!");
        }
        else
        {
          item.Available = true;
          Console.WriteLine($"You have returned {item.Title}");
        }
      }
      else
      {
        Console.WriteLine("Invalid Selection");
      }
    }
  }
}