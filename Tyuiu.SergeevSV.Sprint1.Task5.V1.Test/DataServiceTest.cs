using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SergeevSV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double x1 = 0;
            double y1 = 0;
            double x2 = 3;
            double y2 = 4;

            int expected = 5;
            int actual = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }
    }
}
