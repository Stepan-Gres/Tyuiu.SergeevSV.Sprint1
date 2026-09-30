using Tyuiu.Sergeevsv.Sprint1.Task1.V26.Lib;

namespace Tyiui.Sergeevsv.Sprint1.Task1.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        // 1. Создаем объект класса логики
        DataService ds = new DataService();

        // 2. Задаем тестовые входные данные
        double x = 2.0;
        double y = 3.0;

        // 3. Вызываем ваш метод Calculate
        var res = ds.Calculate(x, y);

        // 4. Проверяем результат (ожидаем ровно 2.0)
        Assert.AreEqual(2.0, res);
    }
}