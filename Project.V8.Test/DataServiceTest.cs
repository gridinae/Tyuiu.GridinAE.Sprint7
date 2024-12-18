using Project.V8.Lib;

namespace Project.V8.Test;

[TestClass]
public class DataServiceTest
{

    private string filePath = @"C:\Users\user\source\repos\Tyuiu.GridinAE.Sprint7\Project.V8.Test\TestCsv.csv";

    [TestMethod]
    public void TestReadCsv()
    {

        string[] expected = ["Рсюср", "123", "тттттт", "+79228410322"];
        CollectionAssert.AreEqual(expected, DataService.ReadCsv(filePath).First());
    }

    [TestMethod]
    public void TestAppendAndDeleteLineInCsv()
    {
        string line = "a,b,c,d,123";
        var originalCsv = DataService.ReadCsv(filePath);
        DataService.AppendCsv(filePath, line);
        DataService.DeleteLineInCsv(filePath, line);
        Assert.AreEqual(originalCsv.Length, DataService.ReadCsv(filePath).Length);
        for (int i = 0; i < originalCsv.Length; i++)
        {
            CollectionAssert.AreEqual(originalCsv[i], DataService.ReadCsv(filePath)[i]);
        }
    }

    [TestMethod]
    public void TestIsCarNumberPresentInCsv()
    {
        Assert.IsTrue(DataService.IsCarNumberPresentInCsv(filePath, "ZVZVZOVSVO"));
        Assert.IsFalse(DataService.IsCarNumberPresentInCsv(filePath, "A012AA"));
    }
}