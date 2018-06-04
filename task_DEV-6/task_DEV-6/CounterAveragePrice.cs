using System.Collections.Generic;

namespace task_DEV_6
{
  /// <summary>
  /// This class counts average price of product.
  /// </summary>
  public class CounterAveragePrice: ICommand
  {
    private List<Product> products = new List<Product>();

    public CounterAveragePrice(List<Product> products)
    {
      this.products = products;
    }

    /// <summary>
    /// This method counts average price of product.
    /// </summary>
    /// <returns>Retruns average price of product.</returns>
    public double Count()
    {
      double generalPrice = 0;
      for (int i = 0; i < products.Count; i++)
      {
        generalPrice += products[i].PriceProduct;
      }
      return generalPrice / products.Count;
    }
  }
}
