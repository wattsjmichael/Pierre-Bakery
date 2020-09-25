using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre;

namespace Pierre.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void isBread_NumberMultipleByFive_True() // Sees if Bread is a interger and changeable
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.isBread(2));
    }
    [TestMethod]
    public void isPastry_NumberMultiplyByTwo_True()// Sees if Pastry is a interger and changeable
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(4, testPastry.isPastry(2));
    }
    [TestMethod]
    public void isBread_BuyTwoGetOneFree_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.isBread(3));
    }
}
}