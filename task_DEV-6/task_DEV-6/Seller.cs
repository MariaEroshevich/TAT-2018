using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_6
{
  /// <summary>
  /// This class calls command to perform a special request.
  /// </summary>
  public class Seller
  {
    private ICommand command;

    public Seller(ICommand command)
    {
      this.command = command;
    }

    /// <summary>
    /// This method calls command.
    /// </summary>
    public void ExecuteCounterCommand()
    {
      command.Count();
    }
  }
}
