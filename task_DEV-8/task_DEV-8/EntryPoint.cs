using System;
using System.Collections.Generic;

namespace task_DEV_8
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      Input input = new Input();
      //List<User> users = input.EnterUseresInformation();
      List<User> users = new List<User>();
      users.Add(new User("Maria", "Eroshevich", "woman", 21));
      users.Add(new User("Anna", "Den", "woman", 20));
      users.Add(new User("Maria", "Kil", "woman", 20));
      users.Add(new User("Kolya", "Kil", "man", 15));
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
