
using NUnit.Framework;
using ConsoleApp10;
namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test()]
        public void TestMethod1()
        {
            NUnit.Framework.Assert.AreEqual(Program.sum(3, 3), 6);
        }
    }
}