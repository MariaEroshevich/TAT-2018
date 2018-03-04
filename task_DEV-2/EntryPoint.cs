using System;

namespace task_DEV_2
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your string: ");
      string line;
      do
      {
        line = Console.ReadLine();
        if (line == string.Empty)
        {
          Console.WriteLine("You entered the empty string. Please, enter again: ");
        }
      }
      while (line == string.Empty);
      StringCreator creator = new StringCreator();
      Console.WriteLine("The string with even symbols: " + creator.CreateEvenIndexesString(line));
    }
  }
}