using System;
using System.Collections.Generic;

namespace task_DEV_8
{
  public class Output
  {
    private Input input = new Input();
    public void OutputUsersInformation()
    {
      List<User> users = input.EnterUseresInformation();
      foreach (User user in users)
      {
        Console.WriteLine("Users:" + user.FirstName + user.LastName + user.Sex + user.Age);
      }
      Reciever reciever = new Reciever(users);
      List<ICommand> commands = new List<ICommand>
      {
        new AverageAge(reciever),
        new SeniorUser(reciever),
        new PopularFemaleName(reciever)
      };
      Invoker invoker = new Invoker();
      invoker.GetCommand(new MacroCommand(commands));
      invoker.StartCommand();
    }
  }
}
