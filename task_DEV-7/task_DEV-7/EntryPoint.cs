
namespace task_DEV_7
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Mark: ");
      //string mark = Console.ReadLine();
      //Console.WriteLine("Model: ");
      //string model = Console.ReadLine();
      //Console.WriteLine("Body type: ");
      //string bodyType = Console.ReadLine();
      //Console.WriteLine("Transmission type: ");
      //string transmissionType = Console.ReadLine();
      //Console.WriteLine("Engine type: ");
      //string engineType = Console.ReadLine();
      //Console.WriteLine("Amount: ");
      //string amount = Console.ReadLine();
      //Console.WriteLine("Power: ");
      //string power = Console.ReadLine();
      //Console.WriteLine("Climate control: ");
      //string climateControl = Console.ReadLine();
      //Console.WriteLine("Interior type: ");
      //string interiorType = Console.ReadLine();

     // ICar car = new BMW("M3", "sedan", "revel", "", "", "", "", "leather");
      string fileName = "D:/TAT-2018/task_DEV-7/task_DEV-7/Catalog.json";
      //ICreator creator = new BMWCreator("M3", "sedan", "petrol", "", "", "", "", "leather");
      //creator.CarCreate();
      CreatorCarOfJson jsonReader = new CreatorCarOfJson(fileName);
      jsonReader.CreateCarOfJson();
    }
  }
}