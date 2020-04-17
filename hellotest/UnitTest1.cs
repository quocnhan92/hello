using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hello;
namespace hellotest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("hello world", Program.createMess());
        }
    }
}
