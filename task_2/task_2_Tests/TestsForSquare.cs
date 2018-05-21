using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_2;

namespace task_2_Tests
{
  [TestClass]
  public class TestsForSquare
  {
    [TestMethod]
    public void PositiveTestsForCalculateSquare()
    {
      Assert.AreEqual(50.0, new Square().CalculateSquare(5.0, 10.0));
      Assert.AreEqual(10000.0, new Square().CalculateSquare(25.0, 400.0));
      Assert.AreEqual(500000000.0, new Square().CalculateSquare(1000.0, 500000.0));
      Assert.AreEqual(0.0, new Square().CalculateSquare(1000.0, 0.0));
    }

    [TestMethod]
    public void NegativeTestsForForCalculateSquare()
    {
      Assert.AreNotEqual(25.0, new Square().CalculateSquare(2.0, 5.0));
      Assert.AreNotEqual(500.0, new Square().CalculateSquare(200.0, 2.0));
      Assert.AreNotEqual(5000000000, new Square().CalculateSquare(10000.0, 500000.0));
    }
  }
}
