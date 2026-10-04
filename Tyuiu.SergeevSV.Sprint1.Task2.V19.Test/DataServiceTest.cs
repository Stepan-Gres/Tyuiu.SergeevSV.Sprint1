using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyiui.SergeevSV.Sprint1.Task2.V19.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int inches = 50;
            
            double expected = 1.27;
            
            double actual = ds.ConvertInchToKm(inches);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
