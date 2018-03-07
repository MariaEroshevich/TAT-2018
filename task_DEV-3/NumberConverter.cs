using System;
using System.Text;

namespace task_DEV_3
{
  /// <summary>
  /// This class converts the decimal number into another number system.
  /// </summary>
  public class NumberConverter
  {
    private int decimalNumber;
    private int notation;
    private StringBuilder convertedNumber = new StringBuilder();
    private string notationSymbols = "0123456789ABCDEFGHIJ";

    public NumberConverter(int decimalNumber, int notation)
    {
      this.decimalNumber = decimalNumber;
      this.notation = notation;
      CheckInputFormat();
    }

    /// <summary>
    /// This method converts entered decimal number to the number from the new notation.
    /// </summary>
    /// <returns>Returns the reverse string with converted number.</returns>
    public string ConvertDecimalNumber()
    {
      while (decimalNumber > 0)
      {
        convertedNumber.Append(notationSymbols[decimalNumber % notation]);
        decimalNumber = decimalNumber / notation;
      }
      return ReverseConvertedString();
    }
    
    private string ReverseConvertedString()
    {
      char[] convertedNumberArray = convertedNumber.ToString().ToCharArray();
      Array.Reverse(convertedNumberArray);
      return new string(convertedNumberArray);
    }

    private void CheckInputFormat()
    {
      if (notation < 2 || notation > 20 || decimalNumber <= 0)
      {
        throw new ArgumentException("You entered wrong notation number or invaliable decimal number.");
      }
    }
  }
}
