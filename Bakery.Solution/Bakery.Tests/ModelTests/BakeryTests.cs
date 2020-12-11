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
    // [TestMethod]
    // public void PastryAmountGetSet_GetSetStaticAmount_Int()
    // {
    //   Pastry.Amount = 5;
    //   int result = Pastry.Amount;
    //   Assert.AreEqual(result, Pastry.Amount);
    // }
  }
}