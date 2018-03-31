using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task_DEV_7.Tests
{
  [TestClass]
  public class CreatorCarOfJsonTests
  {
    [TestMethod]
    public void ReadToObjectJsonNegativeTests()
    {
      Assert.IsFalse(false, "D:/TAT-2018/task_DEV-7/task_DEV-7/Catalog.json", new CreatorCarOfJson("D:/TAT-2018/task_DEV-7/task_DEV-7/person.json"));
    }

    [TestMethod]
    public void ReadToObjectJsonPositiveTests()
    {
      Assert.IsTrue(true, "D:/TAT-2018/task_DEV-7/task_DEV-7/Catalog.json", new CreatorCarOfJson("D:/TAT-2018/task_DEV-7/task_DEV-7/Catalog.json"));
    }
  }
}
