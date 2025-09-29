using Tyuiu.BazilevichAV.Sprint1.Task7.V14.Lib;
namespace Tyuiu.BazilevichAV.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = 2new DataService();
            double x = 2;
            double y = 4;
            double wait = 1.449;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}