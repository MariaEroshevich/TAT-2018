using System;
using System.Collections.Generic;

namespace task_DEV_8
{
  /// <summary>
  /// This class enters information about user.
  /// </summary>
  public class Input
  {
    /// <summary>
    /// This method enters information about users.
    /// </summary>
    /// <returns>Return users.</returns>
    public List<User> EnterUseresInformation()
    {
      List<User> users = new List<User>();
      string firstName;
      string lastName;
      string sex;
      int age;
      string yesOrNo;
      do
      {
        Console.WriteLine("FirstName: ");
        firstName = Console.ReadLine();
        Console.WriteLine("LastName: ");
        lastName = Console.ReadLine();
        Console.WriteLine("Sex: ");
        sex = Console.ReadLine();
        Console.WriteLine("Age: ");
        age = int.Parse(Console.ReadLine());
        users.Add(new User(firstName, lastName, sex, age));
        Console.WriteLine("Enter yes if you want continue to enter the user.");
        yesOrNo = Console.ReadLine();
      }
      while (yesOrNo != "no");
      return users;
    }
  }
}
