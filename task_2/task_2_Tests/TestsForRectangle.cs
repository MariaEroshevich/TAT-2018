using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_2;

namespace task_2_Tests
{
  [TestClass]
  public class TestsForRectangle
  {
    [TestMethod]
    public void PositiveTestsForRectangle()
    {
      Assert.AreEqual(false, new Rectangle(10, 25));
    }
  }
}
