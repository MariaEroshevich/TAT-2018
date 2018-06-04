
namespace task_DEV_8
{
  /// <summary>
  /// This class implements the user. 
  /// </summary>
  public class User
  {
    public string FirstName { get; }
    public string LastName { get; }
    public string Sex { get; }
    public int Age { get; }

    public User(string firstName, string lastName, string sex, int age)
    {
      FirstName = firstName;
      LastName = lastName;
      Sex = sex;
      Age = age;
    }
  }
}
