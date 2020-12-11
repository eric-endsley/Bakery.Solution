using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  public class BakeryTests
  {
    [TestMethod]
    public void ConstructBreadOrder_CreatesInstanceOfBread_Bread() 
    {
      Bread breadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());

    }
    [TestMethod]
    public void ConstructPastryOrder_CreatesInstanceOfPastry_Pastry() 
    {
      Pastry pastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
  }
}