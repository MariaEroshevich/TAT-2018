namespace task_DEV_1
{
  /// <summary>
  /// This class searchs the maximum duplicate successive symbols in the string.
  /// </summary>
  public class SequenceChecker
  {
    private string line;
    private int maxSubstring = 0;

    public SequenceChecker(string line)
    {
      this.line = line;
    }

    /// <summary>
    /// This method is searching the maximum duplicate successive symbols.
    /// </summary>
    /// <returns>Returns the maximum number duplicate successive symbols.</returns>
    public int SearchMaxNumberOfDuplicates()
    {
      int count = 1;
      for (int i = 0; i < line.Length - 1; i++)
      {
        if (line[i].Equals(line[i + 1]))
        {
          count++;
        }
        else if (count > maxSubstring)
        {
          maxSubstring = count;
          count = 1;
        }
        else
        {
          count = 1;
        }
      }
      return maxSubstring;
    }
  }
}
