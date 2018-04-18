using System;
using System.Collections.Generic;

namespace task_DEV_8
{
  /// <summary>
  /// This class defines the actions to be performed as a result of the query.
  /// </summary>
  public class Reciever
  {
    private Input input = new Input();
    private List<User> users = new List<User>();

    public Reciever(List<User> users)
    {
      this.users = users;
    }

    /// <summary>
    /// This method calculates avarage age.
    /// </summary>
    /// <returns>Retruns averege age.</returns>
    public double CalculateAverageAge()
    {
      double averageAge = 0;
      foreach (User user in users)
      {
        averageAge += user.Age;
      }
      return averageAge / users.Count;
    }

    /// <summary>
    /// This method searchs senior user.
    /// </summary>
    /// <returns>Returns senior user.</returns>
    public User SearchSeniorUser()
    {
      User seniorUser;
      users = SortUsersByAge();
      users.Reverse();
      return seniorUser = users[0];
    }

    /// <summary>
    /// This method searchs for a popular female first name.
    /// </summary>
    /// <returns></returns>
    public string SearchPopularFemaleFirstName()
    {
      string popularFemaleName;
      users = SortUsersByFirstName();
      for (int i = 0; i < users.Count - 1; i++)
      {
        if (users[i].FirstName.Equals(users[i + 1].FirstName) && users[i].Sex.Equals("woman") && users[i + 1].Sex.Equals("woman"))
        {
          popularFemaleName = users[i].FirstName;
        }
      }
      return popularFemaleName;
    }

    private List<User> SortUsersByFirstName()
    {
      Comparison<User> comparison = Comparer.CompareUsersFirstName;
      users.Sort(comparison);
      return users;
    }

    private List<User> SortUsersByAge()
    {
      Comparison<User> comparison = Comparer.CompareUsersAge;
      users.Sort(comparison);
      return users;
    }
  }
}
