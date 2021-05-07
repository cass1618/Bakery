using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryModels;

namespace BreadTests
{
  [TestClass]
  public class BreadTest
  {

    [TestMethod]
    public void BreadConstructor_CreatesBreadObject_Bread()
    {
      Bread loaf = new Bread();
      Assert.AreEqual(typeof(Bread), loaf.GetType());
    }

    [TestMethod]
    public void AddLoaves_AddOneLoaf_QuantityOrdered()
    {
      //Arrange
      Bread bread = new Bread();

      //Act
      bread.AddLoaves(1);
      //Assert
      Assert.AreEqual(1, bread.QuantityOrdered);
    }

    [TestMethod]
    public void calcualteTotal_OneLoafTotal_TotalCost()
    {
      //Arrange
      Bread bread = new Bread();
      //Act
      bread.calculateTotal();
      //Assert
      Assert.AreEqual(5, bread.TotalCost);
    }

  }
}