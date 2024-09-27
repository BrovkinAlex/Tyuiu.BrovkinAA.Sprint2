using Tyuiu.BrovkinAA.Sprint2.Task1.V2.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            int a = 135, b = 156, c = 154, d = 174;
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetLogicOperations (a, b, c, d);
            bool[] wait = { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}