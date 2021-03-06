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

  [TestMethod]
    public void AddPastries_AddOnePastry_QuantityOrdered()
    {
      //Arrange
      Pastry pastry = new Pastry();

      //Act
      pastry.AddPastries(1);
      //Assert
      Assert.AreEqual(1, pastry.QuantityOrdered);
    }

    [TestMethod]
    public void calculateTotal_OnePastryTotal_TotalCost()
    {
      //Arrange
      Pastry pastry = new Pastry();
      pastry.PriceEach = 2;
      pastry.AddPastries(1);
      //Act
      pastry.CalculateTotal();
      //Assert
      Assert.AreEqual(2, pastry.TotalCost);
    }

    [TestMethod]
    public void calculateTotal_TwoPastriesTotal_TotalCost()
    {
      //Arrange
      Pastry pastry = new Pastry();
      pastry.PriceEach = 2;
      pastry.AddPastries(2);
      //Act
      pastry.CalculateTotal();
      //Assert
      Assert.AreEqual(4, pastry.TotalCost);
    }

    [TestMethod]
    public void calculateTotal_ThreePastriesTotal_TotalCost()
    {
      //Arrange
      Pastry pastry = new Pastry();
      pastry.PriceEach = 2;
      pastry.AddPastries(3);
      //Act
      pastry.CalculateTotal();
      //Assert
      Assert.AreEqual(5, pastry.TotalCost);
    }
  }
}