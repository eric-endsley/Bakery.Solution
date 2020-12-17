namespace Bakery.Models
{
  public class Pastry
  {
    public static int Amount { get; set; }
    public static int Price { get; private set; }

    public static void PriceCalc()
    {
      Price = Amount * 2 - Amount / 3;
    }
  }
}