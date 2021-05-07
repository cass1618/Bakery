namespace BakeryModels
{
  public class Bread
  {
    public int QuantityOrdered { get; set; }

    public int PriceEach { get; set; }

    public int TotalCost { get; set; }

    public void AddLoaves(int qty)
    {
      QuantityOrdered += qty;
    }

  }
}