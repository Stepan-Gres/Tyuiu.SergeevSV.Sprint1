using Tyuiu.SergeevSV.Sprint1.Task0.V25.Lib;
namespace Tyuiu.SergeevSV.Sprint1.Task0.V25.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        var res=ds.Calculate();
        Assert.AreEqual(3,res);
    }
}