using System;

namespace task_2
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        if (args.Length < 2)
        {
          throw new ArgumentException("Wrong number of arguments.");
        }
        double length = double.Parse(args[0]);
        double wedth = double.Parse(args[1]);

        Square square = new Square();
        Rectangle rectangle = new Rectangle(length, wedth);
        Console.WriteLine("Rectangles square: " + rectangle.GetSquare(square.CalculateSquare));
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
