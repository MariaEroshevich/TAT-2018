using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace task_DEV_7
{
  /// <summary>
  /// This class reads json file.
  /// </summary>
  public class JsonReader
  {
    private ICreator creator;
    private ICar car;
    private string path;

    public JsonReader(string path)
    {
      this.path = path;
    }

    /// <summary>
    /// This method reads json file.
    /// </summary>
    /// <returns>Returns object car.</returns>
    public ICreator ReadToObjectJson()
    {
      MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(path));
      DataContractJsonSerializer serializer = new DataContractJsonSerializer(car.GetType());
      //Dictionary<ICar, object> car = (Dictionary<string, object>) serializer.ReadObject(reader);
      car = (ICar)serializer.ReadObject(memoryStream);
      if (car.Mark == "BMW")
      {
        creator = new BMWCreator(car.Mark, car.Model, car.BodyType, car.TransmissionType, car.EngineType, 
          car.Amount, car.Power, car.ClimateControl, car.InteriorType);
      }
      else if (car.Mark == "Ford")
      {
        creator = new FordCreator(car.Mark, car.Model, car.BodyType, car.TransmissionType, car.EngineType, 
          car.Amount, car.Power, car.ClimateControl, car.InteriorType);
      }
      memoryStream.Close();
      return creator;
    }
  }
}
