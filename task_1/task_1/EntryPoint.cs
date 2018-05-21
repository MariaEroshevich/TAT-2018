using System;
using System.Text;

namespace task_1
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      const char EXCLAMATION_MARK = '!';
      const int MIN_VALUE = 5;
      const int MAX_VALUE = 50;
      const string FIRST_MESSAGE = "Hello World!";
      const string SECOND_MESSAGE = "And hi again!";
      Console.WriteLine(FIRST_MESSAGE);
      Console.WriteLine(SECOND_MESSAGE);

      Random random = new Random();
      int marksNumber = random.Next(MIN_VALUE, MAX_VALUE);
      StringBuilder exclamationMarks = new StringBuilder();
      for (int i = 0; i < marksNumber; i++)
      {
        exclamationMarks.Append(EXCLAMATION_MARK);
      }
      Console.WriteLine(exclamationMarks);
    }
  }
}
