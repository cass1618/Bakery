namespace BakeryModels
{
  public class Bread
  {
    public int QuantityOrdered { get; set; }

    public int Price { get; set; }

    public void AddLoafs(int qty)
    {
      QuantityOrdered += qty;
    }

  }
}