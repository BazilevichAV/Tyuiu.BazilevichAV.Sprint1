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
            double wait = 6.283185307179586;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
