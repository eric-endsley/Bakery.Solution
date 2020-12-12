using System;
using System.Threading;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      string welcome = "Welcome to Pierre's Bakery! \n" +
      "We're the only organic bakery on the Moon and our deals are out of this world!. \n" +
      "We sell Moon Bread and Space Pastries. \n" +
      "Bread costs 5 moon rocks a loaf, and every 3rd loaf you buy is free. \n" +
      "Pastries cost 2 moon rocks each, and every 3rd pastry is half off. \n" +
      "\n" +
      "And don't even think of trying to fool us with plain old Earth Rocks. \n" +
      "The last person who tried that got launched into the void of space! \n";

      Console.WriteLine(welcome);
      Thread.Sleep(4000);
      Console.WriteLine("How many loaves of bread would you like?");
      int breadAmount = int.Parse(Console.ReadLine());
      Thread.Sleep(1000);
      Console.WriteLine("And how many pastries would you like?");
      int pastryAmount = int.Parse(Console.ReadLine());
      
      Bread.Amount = breadAmount;
      Pastry.Amount = pastryAmount;
      Bread.PriceCalc(breadAmount);
      Pastry.PriceCalc(pastryAmount);
      int totalPrice = Bread.Price + Pastry.Price;

      Thread.Sleep(1000);
      Console.WriteLine("\nGreat! That will cost you " + totalPrice + " moon rocks.");
    }
  }
}
