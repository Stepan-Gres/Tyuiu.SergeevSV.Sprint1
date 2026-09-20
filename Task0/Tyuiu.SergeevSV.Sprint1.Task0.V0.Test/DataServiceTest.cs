using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SergeevSV.Sprint1.Task0.V0.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
