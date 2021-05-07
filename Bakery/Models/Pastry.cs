using System;

namespace BakeryModels
{
  public class Pastry
  {
    public int QuantityOrdered { get; set; }

    public int PriceEach { get; set; }

    public int TotalCost { get; set; }

    public void AddPastries(int qty)
    {
      QuantityOrdered += qty;
    }

    public void CalculateTotal()
    {
      int singles = QuantityOrdered % 3;
      int setsOfThree = (QuantityOrdered - singles)/3;
      TotalCost = (singles * PriceEach) + (setsOfThree * ((PriceEach * 2)+(PriceEach/2)));
    }
  }
}