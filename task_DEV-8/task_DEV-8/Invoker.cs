
namespace task_DEV_8
{
  /// <summary>
  /// This class initializes command.
  /// </summary>
  public class Invoker
  {
    private ICommand command;

    public void GetCommand(ICommand command)
    {
      this.command = command;
    }

    public void StartCommand()
    {
      if (command != null)
      {
        command.Execute();
      }
    }
  }
}
