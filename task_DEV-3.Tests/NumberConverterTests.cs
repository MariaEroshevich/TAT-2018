using NUnit.Framework;
using System;

namespace task_DEV_3.Tests
{
  [TestFixture]
  public class NumberConverterTests
  {
    [Test]
    public void NumberConverter_MinValidValue()
    {
      Assert.AreEqual("1010", new NumberConverter(10, 2).ConvertDecimalNumber());
    }

    [Test]
    public void NumberConverter_MaxValidValue()
    {
      Assert.AreEqual("A", new NumberConverter(10, 20).ConvertDecimalNumber());
    }

    [Test]
    public void NumberConverter_ConvertationIntoLettersAndNumbers()
    {
      Assert.AreEqual("3D52", new NumberConverter(15698, 16).ConvertDecimalNumber());
    }

    [Test]
    public void NumberConverter_NullDecimalNumber()
    {
      Assert.AreEqual("0", new NumberConverter(0, 15).ConvertDecimalNumber());
    }

    [Test]
    public void NumberConverter_MinInvalidValue()
    {
      Assert.Throws<ArgumentException>(delegate { new NumberConverter(10, 1); });
    }

    [Test]
    public void NumberConverter_InvalidValue()
    {
      Assert.Throws<ArgumentException>(delegate { new NumberConverter(10, 25); });
    }

    [Test]
    public void NumberConverter_NegativeValue()
    {
      Assert.Throws<ArgumentException>(delegate { new NumberConverter(-10, 5); });
    }
  }
}