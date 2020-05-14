namespace console_library.Models
{
  public class Book : ICheckout
  {
    public string Author { get; set; }
    public string Title { get; set; }
    public bool Available { get; set; }

  
  public Book(string title, string author)
  {
    Title = title;
    Author = author;
    Available = true;
  }
  }

}