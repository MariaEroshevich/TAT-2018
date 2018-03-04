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
      EvenIndexesFinder finder = new EvenIndexesFinder();
      Console.WriteLine("The string with even symbols: " + finder.FindEvenSymbols(line));
    }
  }
}