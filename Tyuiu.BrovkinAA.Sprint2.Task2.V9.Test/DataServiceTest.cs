using Tyuiu.BrovkinAA.Sprint2.Task2.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDot()
        {
            DataService ds = new DataService();
            int x = 7, y = 10;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
            Assert.AreEqual(true, ds.CheckDotInShadedArea(9, 12));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(13, 10));
        }
    }
}