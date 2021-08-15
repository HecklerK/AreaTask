using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaTask;

namespace TestProject;
[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethod()
    {
        Assert.AreEqual(28.274333882308138, Area.AreaCircle(3));
        Assert.AreEqual(6, Area.AreaTriangle(5, 4, 3));
    }
}