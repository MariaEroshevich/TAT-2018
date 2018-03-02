using System;

namespace task_DEV_1
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      SequenceChecker sequenceChecker = new SequenceChecker(args[0]);
      Console.WriteLine("The maximum duplicate successive symbols: " + sequenceChecker.SearchMaxNumberOfDuplicates());
    }
  }
}
