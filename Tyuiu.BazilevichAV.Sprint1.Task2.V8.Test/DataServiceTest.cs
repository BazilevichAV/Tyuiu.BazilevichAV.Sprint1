using Tyuiu.BazilevichAV.Sprint1.Task2.V8.Lib;
namespace Tyuiu.BazilevichAV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            var res = ds.CalculatePerimetr(x, y);
            Assert.AreEqual(6, res);
        }
    }
}
