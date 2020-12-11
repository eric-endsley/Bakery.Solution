using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadAmountGetSet_GetSetStaticAmount_Int()
    {
      Bread.Amount = 3;
      int expect = 3;
      Assert.AreEqual(expect, Bread.Amount);
    }
    [TestMethod]
    public void PastryAmountGetSet_GetSetStaticAmount_Int()
    {
      Pastry.Amount = 5;
      int expect = 5;
      Assert.AreEqual(expect, Pastry.Amount);
    }

    [TestMethod]
    public void BreadPriceGet_GetStaticPrice_Int()
    {
      int expect = 0;
      Assert.AreEqual(expect, Bread.Price);
    }
    [TestMethod]
    public void PastryPriceGet_GetStaticPrice_Int()
    {
      int expect = 0;
      Assert.AreEqual(expect, Pastry.Price);
    }
    [TestMethod]
    public void BreadPriceCalc_AddFivePricePerBread_Int()
    {
      Bread.Amount = 2;
      Bread.PriceCalc(Bread.Amount);
      int expect = 10;

      Assert.AreEqual(expect, Bread.Price);
    }
    [TestMethod]
    public void BreadPriceCalc_EachThirdBreadCostZero_Void()
    {
      Bread.Amount = 3;
      Bread.PriceCalc(Bread.Amount);
      int expect = 10;

      Assert.AreEqual(expect, Bread.Price);
    }
    
  }
}