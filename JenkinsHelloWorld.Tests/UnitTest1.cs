using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsHelloWorld;
namespace JenkinsHelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", ProgramTest.Display());
        }
    }
}
