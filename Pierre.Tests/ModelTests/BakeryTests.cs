using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre;

namespace Pierre.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void isBakery_NumberMultipleByThree_True()
    {
      Bakery testBakery = new Bakery();
      Assert.AreEqual(true, testBakery.isBakery(5));
    }

    
  }
}