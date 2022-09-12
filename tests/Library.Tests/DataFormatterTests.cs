namespace TestDateFormat;

public class DateFormatterTests

{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDateCorrectFormat()
    {
        const string expected = "2022-09-12";
        string date = DateFormatter.ChangeFormat("12/09/2022");
        Assert.AreEqual(expected, date);
    }
    [Test]
    public void TestDateIncorrectFormat()
    {
        const string expected = "Formato incorrecto";
        string date = DateFormatter.ChangeFormat("2022/09/12");
        Assert.AreEqual(expected, date);
    }
    [Test]
    public void TestVoidDate()
    {
        const string expected = "Fecha vacia";
        string date = DateFormatter.ChangeFormat("");
        Assert.AreEqual(expected, date);
    }
}