using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaTask;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Console.WriteLine(Area.areaCircle(3).ToString());
            Console.WriteLine(Area.areaTriangle(2, 2.3, 2).ToString());
        }
    }
}
