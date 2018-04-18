using System;
using System.Collections.Generic;

namespace task_DEV_8
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      Input input = new Input();
      List<User> users = input.EnterUseresInformation();
      Reciever reciever = new Reciever(users);
      AverageAge averageAge = new AverageAge(reciever);
      averageAge.Execute();
      SeniorUser seniorUser = new SeniorUser(reciever);
      seniorUser.Execute();
      PopularFemaleName popularFemaleName = new PopularFemaleName(reciever);
      popularFemaleName.Execute();
    }
  }
}
