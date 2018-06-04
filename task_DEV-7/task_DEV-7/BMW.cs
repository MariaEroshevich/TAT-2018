
namespace task_DEV_7
{
  /// <summary>
  /// This class implements the car BMW.
  /// </summary>
  public class BMW : Car
  {
    public BMW(string model, string bodyType, string tramsmissionType, string engimeType, string amount,
      string power, string climateControl, string interiorType)
    {
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
