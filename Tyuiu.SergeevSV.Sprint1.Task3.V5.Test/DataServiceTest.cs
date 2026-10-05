using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SergeevSV.Sprint1.Task3.V5.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double scale = 120.0;
            double distance = 3.5;
            double expected = 420.0;
            
            double actual = ds.DistanceLength(scale, distance);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
