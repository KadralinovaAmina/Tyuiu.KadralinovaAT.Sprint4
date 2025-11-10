using Tyuiu.KadralinovaAT.Sprint4.Task2.V12.Lib;

namespace Tyuiu.KadralinovaAT.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7, 2, 4};
            int res = ds.Calculate(numsArray);
            int wait = 47;
            Assert.AreEqual(wait, res);
        }
    }
}
