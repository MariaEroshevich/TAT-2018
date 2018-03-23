using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_6
{
  public class RecieverCommand
  {
    private List<Product> products = new List<Product>();

    public RecieverCommand(List<Product> products)
    {
      this.products = products;
    }

    //public double CountAllProducts()
    //{
    //  double amountProduct = 0;

    //  for (int i = 0; i < products.Count; i++)
    //  {
    //    amountProduct += products[i].AmountProduct;
    //  }
    //  return amountProduct;
    //}
  }
}
