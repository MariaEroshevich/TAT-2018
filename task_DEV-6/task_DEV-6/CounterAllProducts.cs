using System.Collections.Generic;

namespace task_DEV_6
{
  /// <summary>
  /// This class counters the numbers of all products.
  /// </summary>
  public class CounterAllProducts: ICommand
  {
    private List<Product> products = new List<Product>();

    public CounterAllProducts(List<Product> products)
    {
      this.products = products;
    }

    /// <summary>
    /// This method counts the number of all products.
    /// </summary>
    /// <returns>Returns number of products.</returns>
    public double Count()
    {
      double amountProduct = 0;

      for (int i = 0; i < products.Count; i++)
      {
        amountProduct += products[i].AmountProduct;
      }
      return amountProduct;
    }
  }
}
