using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread 
  {
    
    public static int Amount { get; set; }
    public static int Price { get; private set; }

    public static void PriceCalc(int breadAmount)
    {
      Bread.Price = Bread.Amount * 4;
    }
  }
  public class Pastry
  {
    public static int Amount { get; set; }
    public static int Price { get; private set; }
  }
}