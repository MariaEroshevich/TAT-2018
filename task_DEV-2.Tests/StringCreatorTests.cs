using Xunit;

namespace task_DEV_2.Tests
{
  public class StringCreatorTests
  {
    [Fact]
    public void CreateEvenIndexesStringTest()
    {
      Assert.Equal("aceg", new StringCreator().CreateEvenIndexesString("abcdefg"));
    }

    [Fact]
    public void CreateEvenIndexesStringTest_TestWithSingleValue()
    {
      Assert.Equal("a", new StringCreator().CreateEvenIndexesString("a"));
    }
  }
}
