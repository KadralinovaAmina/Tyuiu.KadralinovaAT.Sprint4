using Tyuiu.KadralinovaAT.Sprint4.Task5.V2.Lib;
namespace Tyuiu.KadralinovaAT.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 4, -4, 7, 8, 9 },
                                          { 9, 5, -9, 7, 8 },
                                          { 7, 4, 9, -4, 6 },
                                          { 4, 4, -7, 4, 4 },
                                          { 4, -5, 8, 6, 7 } };

            int res = ds.Calculate(mas2);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
