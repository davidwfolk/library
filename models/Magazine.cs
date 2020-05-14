namespace console_library.Models
{
  public class Magazine : ICheckout
  {
    public string Title { get; set; }
    public string Month { get; set; }
    public bool Available { get; set; }

  
  public Magazine(string title, string month)
  {
    Title = title;
    Month = month;
    Available = true;
  }
  }

}