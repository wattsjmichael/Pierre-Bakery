using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre;

namespace Pierre.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void isBread_NumberMultipleByTwo_True() // Sees if Bread is a interger and changeable
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.isBread(1));
    }
    [TestMethod]
    public void isPastry_NumberMultiplyByTwo_True()// Sees if Pastry is a interger and changeable
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(true, testPastry.isPastry(2));
    }
    [TestMethod]
    public void isBread_NumberDivideByTwoAddOneBread_Test()
    {
    //arrange
    Bread testBread = new Bread();
    int userBread = 3;
    Assert.AreEqual(true, testBread.isBread(userBread));
    }
  }
}