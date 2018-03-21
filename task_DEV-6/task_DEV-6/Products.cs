using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_6
{
  public class Products
  {
    private string typeProduct;
    private string nameProduct;
    private double amountProduct;
    private double priceProduct;

    

    public Products(string typeProduct, string nameProduct, double amountProduct, double priceProduct, ICounting counting)
    {
      this.typeProduct = typeProduct;
      this.nameProduct = nameProduct;
      this.amountProduct = amountProduct;
      this.priceProduct = priceProduct;
      Counting = counting;
    }

    public ICounting Counting { private get; set; }
  }
}
