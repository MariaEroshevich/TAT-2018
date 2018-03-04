using System.Text;

namespace task_DEV_2
{
  /// <summary>
  /// This class creates the string with with symbols for which even indexes.
  /// </summary>
  public class StringCreator
  {
    /// <summary>
    /// This method creates the string with symbols for which even indexes.
    /// </summary>
    /// <param name="line">Entered string.</param>
    /// <returns>Returns the string with symbols for which even indexes.</returns>
    public string CreateEvenIndexesString(string line)
    {
      StringBuilder result = new StringBuilder();
      for (int i = 0; i < line.Length; i += 2)
      {
        result.Append(line[i]);
      }
      return result.ToString();
    }
  }
}