using ConsoleApp2;

namespace TestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            Caluculator c = new Caluculator();
            int result = c.Add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}