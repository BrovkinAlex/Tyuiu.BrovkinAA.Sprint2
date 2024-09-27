using Tyuiu.BrovkinAA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.FindCardNameAndValue(1, 11);
            string wait = "Валет пик";
            Assert.AreEqual(wait, res);
        }
    }
}