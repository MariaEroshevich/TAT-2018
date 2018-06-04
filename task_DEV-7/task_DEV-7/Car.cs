using System.Runtime.Serialization;

namespace task_DEV_7
{
  /// <summary>
  /// This class implements the car.
  /// </summary>
  [DataContract]
  public class Car
  {
    [DataMember]
    public string Mark { get; set; }
    [DataMember]
    public string Model { get; set; }
    [DataMember]
    public string BodyType { get; set; }
    [DataMember]
    public string TransmissionType { get; set; }
    [DataMember]
    public string EngineType { get; set; }
    [DataMember]
    public string Amount { get; set; }
    [DataMember]
    public string Power { get; set; }
    [DataMember]
    public string ClimateControl { get; set; }
    [DataMember]
    public string InteriorType { get; set; }
  }
}
