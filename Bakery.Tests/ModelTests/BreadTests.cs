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
    public void calculateTotal_OneLoafTotal_TotalCost()
    {
      //Arrange
      Bread bread = new Bread();
      bread.PriceEach = 5;
      bread.AddLoaves(1);
      //Act
      bread.CalculateTotal();
      //Assert
      Assert.AreEqual(5, bread.TotalCost);
    }

    [TestMethod]
    public void calculateTotal_TwoLoavesTotal_TotalCost()
    {
      //Arrange
      Bread bread = new Bread();
      bread.PriceEach = 5;
      bread.AddLoaves(2);
      //Act
      bread.CalculateTotal();
      //Assert
      Assert.AreEqual(10, bread.TotalCost);
    }

    [TestMethod]
    public void calculateTotal_ThreeLoavesTotal_TotalCost()
    {
      //Arrange
      Bread bread = new Bread();
      bread.PriceEach = 5;
      bread.AddLoaves(3);
      //Act
      bread.CalculateTotal();
      //Assert
      Assert.AreEqual(10, bread.TotalCost);
    }

  }
}