using System.Text;

namespace task_DEV_2
{
  /// <summary>
  /// This class finds even index in the string.
  /// </summary>
  public class EvenIndexesFinder
  {
    /// <summary>
    /// This method finds even index in the string.
    /// </summary>
    /// <param name="line">Entered string.</param>
    /// <returns>Returns the string with even symbols.</returns>
    public string FindEvenSymbols(string line)
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