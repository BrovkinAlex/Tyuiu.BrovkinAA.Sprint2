using Tyuiu.BrovkinAA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDot()
        {
            DataService ds = new DataService();
            bool[] res = { ds.CheckDotInShadedArea(0.5, 0.5), ds.CheckDotInShadedArea(0.5, 0), ds.CheckDotInShadedArea(1, 1), ds.CheckDotInShadedArea(2, 2)};
            bool[] wait = { true, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}