
namespace task_DEV_8
{
  /// <summary>
  /// This class implements command.
  /// </summary>
  public class AverageAge: ICommand
  {
    private Reciever reciever;

    public AverageAge(Reciever reciever)
    {
      this.reciever = reciever;
    }

    /// <summary>
    /// This method implements command.
    /// </summary>
    public void Execute()
    {
      reciever.CalculateAverageAge();
    }
  }
}
