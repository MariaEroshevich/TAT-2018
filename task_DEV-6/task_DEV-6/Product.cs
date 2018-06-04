
namespace task_DEV_6
{
  /// <summary>
  /// This class gets and sets element in product.
  /// </summary>
  public class Product
  {
    private string typeProduct;
    private string nameProduct;
    private double amountProduct;
    private double priceProduct;

    public string TypeProduct { get { return typeProduct; }  set { typeProduct = value; } }

    public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }

    public double AmountProduct { get { return amountProduct; } set { amountProduct = value; } }

    public double PriceProduct { get { return priceProduct; } set { priceProduct = value; } }

    public Product(string typeProduct, string nameProduct, double amountProduct, double priceProduct)
    {
      this.typeProduct = typeProduct;
      this.nameProduct = nameProduct;
      this.amountProduct = amountProduct;
      this.priceProduct = priceProduct;
    }
  }
}
