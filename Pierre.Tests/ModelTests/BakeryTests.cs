using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;

namespace Pierre.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void breadCost_NumberMultipleByFive_True() // Sees if Bread is a interger and changeable
    {
      Order testBread = new Order();
      Assert.AreEqual(10, testBread.breadCost(2));
    }
    [TestMethod]
    public void pastryCost_NumberMultiplyByTwo_True()// Sees if Pastry is a interger and changeable
    {
      Order testPastry = new Order();
      Assert.AreEqual(4, testPastry.pastryCost(2));
    }
    [TestMethod]
    public void breadCost_BuyTwoGetOneFree_True()
    {
      Order testBread = new Order();
      Assert.AreEqual(10, testBread.breadCost(3));
    }
    [TestMethod]
    public void breadCost_BuyFourGetTwoFree_True()
    {
      Order testBread = new Order();
      Assert.AreEqual(20, testBread.breadCost(6));
    }
    [TestMethod]
    public void pastryCost_BuyThreeforFive_True()
    {
      Order testPastry = new Order();
      Assert.AreEqual(5, testPastry.pastryCost(3));
    }
    [TestMethod]
    public void pastryCost_BuySixforTen_True()
    {
      Order testPastry = new Order();
      Assert.AreEqual(10, testPastry.pastryCost(6));
    }
    [TestMethod]
    public void  pastryCost_BuySevenforTwelve_True()
    {
      Order testPastry = new Order();
      Assert.AreEqual(12, testPastry.pastryCost(7));
    }
    [TestMethod]
    public void pastryCost_BuyEightforFourteen_True()
    {
      Order testPastry = new Order();
      Assert.AreEqual(14, testPastry.pastryCost(8));
    }
  }
}
