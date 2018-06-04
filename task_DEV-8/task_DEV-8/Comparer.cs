using System;

namespace task_DEV_8
{
  /// <summary>
  /// This class compares information about users.
  /// </summary>
  public class Comparer
  {
    /// <summary>
    /// This method compares users first name.
    /// </summary>
    /// <param name="firstUser">First user.</param>
    /// <param name="secondUser">Second user</param>
    /// <returns>Retruns 0 if first name of the first user equal to the first name of the second user.
    /// Retruns -1 if first name of the first user preceded to the first name of the second user.
    /// Return 1 if first name of the first user followed to the first name of the second user.</returns>
    public static int CompareUsersFirstName(User firstUser, User secondUser)
    {
      return String.Compare(firstUser.FirstName, secondUser.FirstName);
    }

    /// <summary>
    /// This method compares users age.
    /// </summary>
    /// <param name="firstUser">First user.</param>
    /// <param name="secondUser">Second user.</param>
    /// <returns>Retruns 0 if first name of the first user equal to the first name of the second user.
    /// Retruns -1 if first name of the first user preceded to the first name of the second user.
    /// Return 1 if first name of the first user followed to the first name of the second user.</returns>
    public static int CompareUsersAge(User firstUser, User secondUser)
    {
      return firstUser.Age.CompareTo(secondUser.Age);
    }
  }
}
