using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread 
  {
    
    public static int Amount { get; set; }
    public static int Price { get { return 10; } }
   
  }
  public class Pastry
  {
    public static int Amount { get; set; }
    public static int Price { get; }
  }
}