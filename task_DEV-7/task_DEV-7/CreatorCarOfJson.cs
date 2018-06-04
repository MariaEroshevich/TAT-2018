using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace task_DEV_7
{
  /// <summary>
  /// This class creats cars of JSON file.
  /// </summary>
  public class CreatorCarOfJson
  {
    private List<ICreator> creator = new List<ICreator>();
    private List<Car> carList = new List<Car>();
    private string fileName;

    public CreatorCarOfJson(string fileName)
    {
      this.fileName = fileName;
    }

    /// <summary>
    /// This method reads json to object.
    /// </summary>
    /// <returns>Returns lidt of car.</returns>
    public List<Car> ReadToObjectJson()
    {
      DataContractJsonSerializer serializer = new DataContractJsonSerializer(new List<Car>().GetType());
      using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
      {
        carList = (List<Car>)serializer.ReadObject(fileStream); 
      }
      return carList;
    }

    /// <summary>
    /// This method creates car of JSON file.
    /// </summary>
    /// <returns>Returns list of cars.</returns>
    public List<ICreator> CreateCarOfJson()
    {
      List<Car> carList = ReadToObjectJson();
      foreach (Car car in carList)
      {
        if (car.Mark == "BMW")
        {
          creator.Add(new BMWCreator(car.Model, car.BodyType, car.TransmissionType, car.EngineType,
            car.Amount, car.Power, car.ClimateControl, car.InteriorType));
        }
        else if (car.Mark == "Ford")
        {
          creator.Add(new FordCreator(car.Model, car.BodyType, car.TransmissionType, car.EngineType,
            car.Amount, car.Power, car.ClimateControl, car.InteriorType));
        }
      }
      return creator;
    }
  }
}
