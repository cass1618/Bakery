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

    // public void CalculateTotal()
    // {
    // }
  }
}