using System;
using System.Collections.Generic;

namespace task_DEV_6
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      //List<Product> products = new List<Product>();
      //products.Add(new Product("red", "pen", 2.0, 2.95));
      //products.Add(new Product("green", "pen", 5.0, 1.95));
      string typeProduct = string.Empty;
      string nameProduct = string.Empty;
      double amountProduct = 0;
      double priceProduct = 0;
      List<Product> products = new List<Product>();
      Console.WriteLine("Enter number of poducts.");
      int numberProducts = int.Parse(Console.ReadLine());
      for (int i = 0; i < numberProducts; i++)
      {
        Console.WriteLine("Type: ");
        typeProduct = Console.ReadLine();
        Console.WriteLine("Name: ");
        nameProduct = Console.ReadLine();
        Console.WriteLine("Amount of products: ");
        amountProduct = double.Parse(Console.ReadLine());
        Console.WriteLine("Price product: ");
        priceProduct = double.Parse(Console.ReadLine());
        products.Add(new Product(typeProduct, nameProduct, amountProduct, priceProduct));
      }


      CounterAllProducts counterAllProducts = new CounterAllProducts(products);
      counterAllProducts.Count();
      Console.WriteLine("Enter command: ");
      string command = Console.ReadLine();
      RecieverCommand recieverCommand = new RecieverCommand();
      
    }
  }
}