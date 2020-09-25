using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre;

namespace Pierre.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void isBread_NumberMultipleByThree_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.isBread(5));
    }
    [TestMethod]
    public void isPastry_NumberMultiplyByTwo_True()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(true, testPastry.isPastry(4));
    }
  }
}