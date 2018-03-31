using System;
using System.Collections.Generic;

namespace task_DEV_7
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Mark: ");
      string mark = Console.ReadLine();
      Console.WriteLine("Model: ");
      string model = Console.ReadLine();
      Console.WriteLine("Body type: ");
      string bodyType = Console.ReadLine();
      Console.WriteLine("Transmission type: ");
      string transmissionType = Console.ReadLine();
      Console.WriteLine("Engine type: ");
      string engineType = Console.ReadLine();
      Console.WriteLine("Amount: ");
      string amount = Console.ReadLine();
      Console.WriteLine("Power: ");
      string power = Console.ReadLine();
      Console.WriteLine("Climate control: ");
      string climateControl = Console.ReadLine();
      Console.WriteLine("Interior type: ");
      string interiorType = Console.ReadLine();

      string fileName = "D:/TAT-2018/task_DEV-7/task_DEV-7/Catalog.json";
      ICreator creator = new BMWCreator(mark, model, bodyType, transmissionType, engineType, amount, power, interiorType);
      creator.CarCreate();
      creator = new FordCreator(mark, model, bodyType, transmissionType, engineType, amount, power, interiorType);
      creator.CarCreate();
      CreatorCarOfJson creatorCarOfJson = new CreatorCarOfJson(fileName);
      creatorCarOfJson.CreateCarOfJson();
    }
  }
}