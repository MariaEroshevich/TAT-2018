using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_7
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      //string mark = Console.ReadLine();
      //string model = Console.ReadLine();
      //string bodyType = Console.ReadLine();
      //string transmissionType = Console.ReadLine();
      //string engineType = Console.ReadLine();
      //string amount = Console.ReadLine();
      //string power = Console.ReadLine();
      //string climateManagement = Console.ReadLine();
      //string interiorType = Console.ReadLine();

      // ICar car = new BMW("M3", "sedan", "revel", "", "", "", "", "leather");
      string path = "Catalog.json";
      ICreator creator = new BMWCreator("BMW", "M3", "sedan", "petrol", "", "", "", "", "leather");
      creator.CarCreate();
      JsonReader jsonReader = new JsonReader(path);
      jsonReader.ReadToObjectJson();
    }
  }
}
