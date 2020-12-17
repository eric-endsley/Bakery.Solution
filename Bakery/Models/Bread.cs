namespace Bakery.Models
{
  public class Bread 
  {
    public static int Amount { get; set; }
    public static int Price { get; private set; }

    public static void PriceCalc()
    {
      int freeBreadCount = Amount / 3;
      Price = (Amount - freeBreadCount) * 5;
    }
  }
}