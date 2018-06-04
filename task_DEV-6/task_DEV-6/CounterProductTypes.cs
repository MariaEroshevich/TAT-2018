using System.Collections.Generic;

namespace task_DEV_6
{
  /// <summary>
  /// This class counts the number of products types.
  /// </summary>
  public class CounterProductTypes : ICommand
  {
    private List<Product> products = new List<Product>();

    public CounterProductTypes(List<Product> products)
    {
      this.products = products;
    }

    /// <summary>
    /// This method counts the number of products types.
    /// </summary>
    /// <returns>Returns the number of prodects types.</returns>
    public double Count()
    {
      List<string> uniqueTypes = new List<string>();
      for (int i = 0; i < products.Count; i++)
      {
        if (!uniqueTypes.Contains(products[i].TypeProduct))
        {
          uniqueTypes.Add(products[i].TypeProduct);
        }
      }
      return uniqueTypes.Count;
    }
  }
}
