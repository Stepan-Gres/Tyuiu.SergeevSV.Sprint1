using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SergeevSV.Sprint1.Task4.V16.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            
            double expected = 0.2;
            double actual = ds.Calculate(x);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
