using System;
using System.Collections.Generic;

namespace task_DEV_6
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      List<Product> products = new List<Product>();
      Console.WriteLine("Enter number of poducts.");
      int numberProducts = int.Parse(Console.ReadLine());
      for (int i = 0; i < numberProducts; i++)
      {
        Console.WriteLine("Type: ");
        string typeProduct = Console.ReadLine();
        Console.WriteLine("Name: ");
        string nameProduct = Console.ReadLine();
        Console.WriteLine("Amount of products: ");
        double amountProduct = double.Parse(Console.ReadLine());
        Console.WriteLine("Price product: ");
        double priceProduct = double.Parse(Console.ReadLine());
        products.Add(new Product(typeProduct, nameProduct, amountProduct, priceProduct));
      }
      Console.WriteLine("Enter command: ");
      string command = Console.ReadLine();
      EnteredCommand enteredCommand = new EnteredCommand(command);
      CounterAllProducts counterAllProducts = new CounterAllProducts(products);
      Seller seller = new Seller(counterAllProducts);
      seller.ExecuteCounterCommand();
    }
  }
}