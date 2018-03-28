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
  public class BMW: ICar
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

    public BMW(string mark, string model, string bodyType, string tramsmissionType, string engimeType, string amount,
      string power, string climateControl, string interiorType)
    {
      Mark = mark;
      Model = model;
      BodyType = bodyType;
      TransmissionType = tramsmissionType;
      EngineType = engimeType;
      Amount = amount;
      Power = power;
      ClimateControl = climateControl;
      InteriorType = interiorType;
    }
  }
}
