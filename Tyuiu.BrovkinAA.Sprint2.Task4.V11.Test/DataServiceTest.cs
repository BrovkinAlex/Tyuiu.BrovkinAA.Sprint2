using Tyuiu.BrovkinAA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 2);
            double wait = 25;
            Assert.AreEqual(wait, res);
            Assert.AreEqual(-1, ds.Calculate(64, 63));
        }
    }
}