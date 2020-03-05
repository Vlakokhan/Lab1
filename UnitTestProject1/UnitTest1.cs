using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            double result1 = lab1.Program.volume(a);
            Assert.AreEqual(64, result1);
            double result2 = lab1.Program.square(a);
            Assert.AreEqual(96, result2);
        }
    }
}
