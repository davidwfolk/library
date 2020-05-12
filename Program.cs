using System;
using console_library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Author = "Shel Silverstein";
            myBook.Title = "Where The Sidewalk Ends";
        }
    }
}
