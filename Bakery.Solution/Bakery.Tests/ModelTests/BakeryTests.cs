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
      result = Bread.Amount;
      Assert.AreEqaul(result, Bread.Amount);
    }
    [TestMethod]
    public void PastryAmountGetSet_GetSetStaticAmount_Int()
    {
      Pastry.Amount = 5
      result = Pastry.Amount;
      Assert.AreEqual(result, Pastry.Amount);
    }
  }
}