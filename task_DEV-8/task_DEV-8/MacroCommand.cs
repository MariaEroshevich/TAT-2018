using System.Collections.Generic;

namespace task_DEV_8
{
  /// <summary>
  /// This class contains commands.
  /// </summary>
  public class MacroCommand: ICommand
  {
    private List<ICommand> commands = new List<ICommand>();

    public MacroCommand(List<ICommand> commands)
    {
      this.commands = commands;
    }

    public void Execute()
    {
      foreach (ICommand command in commands)
      {
        command.Execute();
      }
    }
  }
}
