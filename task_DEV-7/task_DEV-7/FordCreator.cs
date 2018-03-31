
namespace task_DEV_7
{
  /// <summary>
  /// This class created Ford cars.
  /// </summary>
  public class FordCreator: ICreator
  {
    private string model;
    private string bodyType;
    private string transmissionType;
    private string engineType;
    private string amount;
    private string power;
    private string climateControl;
    private string interiorType;

    public FordCreator(string model, string bodyType, string transmissionType, string engineType, string amount,
      string power, string climateControl, string interiorType)
    {
      this.model = model;
      this.bodyType = bodyType;
      this.transmissionType = transmissionType;
      this.engineType = engineType;
      this.amount = amount;
      this.power = power;
      this.climateControl = climateControl;
      this.interiorType = interiorType;
      CarCreate();
    }

    public Car CarCreate()
    {
      return new Ford(model, bodyType, transmissionType, engineType, amount, power, climateControl, interiorType);
    }
  }
}
