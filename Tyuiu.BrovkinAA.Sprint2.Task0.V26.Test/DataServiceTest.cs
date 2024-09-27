using Tyuiu.BrovkinAA.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1045, y = 975;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = { false, false, false, true, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}