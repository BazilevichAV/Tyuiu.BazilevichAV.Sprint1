using Tyuiu.BazilevichAV.Sprint1.Task3.V0.Lib;
namespace Tyuiu.BazilevichAV.Sprint1.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 2;
            double wait = 12.566;
            var res = Math.Round(ds.CylinderVolume(r, h), 3);
            Assert.AreEqual(Math.Round(wait, 3), res);
        }
    }
}
