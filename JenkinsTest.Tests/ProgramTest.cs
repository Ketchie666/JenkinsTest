using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest.Tests
{
    [TestClass]
    public partial class ProgramTest
    {
        [TestMethod]
        public void GetOutputTest()
        {
            Assert.AreEqual("Hello World", Program.GetOutput());
        }
    }
}
