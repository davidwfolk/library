using System;
using console_library.Models;

namespace console_library
{
  public class App
  {
    public Library MyLibrary { get; set; }
    public bool Running { get; private set; }

    public void Run()
    {
      MyLibrary = new Library("Kuna", "Kuna Library");
      Console.Clear();
      MyLibrary.LibrarySetup();
      Running = true;

      while (Running)
      {
        MakeSelection();
      }
    }
    private void MakeSelection()
    {
      Console.WriteLine("Please choose between the following: (C)heckout, (R)eturn a book, or (Q)uit");
      string input = Console.ReadLine();
      switch (input.ToLower())
      {
        case "c":
          MyLibrary.CheckoutBook();
          break;
        case "r":
          MyLibrary.ReturnBook();
          break;
        case "q":
          Running = false;
          Console.WriteLine("Thanks for visiting!");
          Console.ReadLine();
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
    }
  }

}