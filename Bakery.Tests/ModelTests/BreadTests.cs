using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadModels;

namespace BreadTests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesBreadObject_Bread()
    {
      Bread loaf = new Bread();
      Assert.AreEqual(typeof(Bread), loaf.GetType());
    }

  }
}