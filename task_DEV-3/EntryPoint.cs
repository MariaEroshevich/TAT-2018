using System;

namespace task_DEV_3
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        int decimalNumber = int.Parse(args[0]);
        int notation = int.Parse(args[1]);
        NumberConverter numberConverter = new NumberConverter(decimalNumber, notation);
        Console.WriteLine(numberConverter.ConvertDecimalNumber());
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
