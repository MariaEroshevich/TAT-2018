using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_7
{
  /// <summary>
  /// This class 
  /// </summary>
  public class Ford: ICar
  {
    public string Mark { get; set; }
    public string Model { get; set; }
    public string BodyType { get; set; }
    public string TransmissionType { get; set; }
    public string EngineType { get; set; }
    public string Amount { get; set; }
    public string Power { get; set; }
    public string ClimateControl { get; set; }
    public string InteriorType { get; set; }

    public Ford(string mark, string model, string bodyType, string transmissionType, string engimeType, string amount,
      string power, string climateControl, string interiorType)
    {
      Model = model;
      BodyType = bodyType;
      TransmissionType = transmissionType;
      EngineType = engimeType;
      Amount = amount;
      Power = power;
      ClimateControl = climateControl;
      InteriorType = interiorType;
    }
  }
}
