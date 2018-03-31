
namespace task_DEV_7
{
  /// <summary>
  /// This class implements the car Ford.
  /// </summary>
  public class Ford: Car
  {
    //private string mark = "Ford";

    public Ford(string model, string bodyType, string transmissionType, string engimeType, string amount,
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
