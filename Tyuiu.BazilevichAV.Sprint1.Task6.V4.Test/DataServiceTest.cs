using Tyuiu.BazilevichAV.Sprint1.Task6.V4.Lib;
namespace Tyuiu.BazilevichAV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "Стеклянный глиняный маринованный кованый обдолбанный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(value);

            string wait = "Стеклянный маринованный обдолбанный";
            Assert.AreEqual(wait, res);
        }
    }
}