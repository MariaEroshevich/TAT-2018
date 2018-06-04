using System.Collections.Generic;

namespace task_DEV_6
{
  /// <summary>
  /// This class counts average price of each type of product.
  /// </summary>
  public class CounterAveragePriceTypes: ICommand
  {
    private List<Product> products = new List<Product>();
    private string type;

    public CounterAveragePriceTypes(List<Product> products, string type)
    {
      this.products = products;
      this.type = type;
    }

    /// <summary>
    /// This method counts average price of each type of product.
    /// </summary>
    /// <returns>Returns average price of each type of product.</returns>
    public double Count()
    {
      double generalTypePrice = 0;
      int count = 0;
      for (int i = 0; i < products.Count; i++)
      {
        if (products[i].TypeProduct.Equals(type))
        {
          generalTypePrice += products[i].PriceProduct;
          count++;
        }
      }
      return generalTypePrice / count;
    }
  }
}
