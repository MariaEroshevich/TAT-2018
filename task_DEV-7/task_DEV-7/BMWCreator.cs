
namespace task_DEV_7
{
  /// <summary>
  /// This class creates BMW cars.
  /// </summary>
  public class BMWCreator: ICreator
  {
    private string model;
    private string bodyType;
    private string transmissionType;
    private string engineType;
    private string amount;
    private string power;
    private string climateControl;
    private string interiorType;

    public BMWCreator(string model, string bodyType, string transmissionType, string engineType, string amount,
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

    private Car CarCreate()
    {
      return new BMW(model, bodyType,transmissionType, engineType, amount, power, climateControl, interiorType);
    }
  }
}
