using System;
using System.Collections.Generic;

namespace console_library.Models
{

 public interface ICheckout
  {
    public string Title { get; set; }
    public bool Available { get; set; }
  }
}