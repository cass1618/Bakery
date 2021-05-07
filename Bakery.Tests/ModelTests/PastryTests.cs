using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryModels;

namespace BakeryTests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesPastryObject_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    
  }
}