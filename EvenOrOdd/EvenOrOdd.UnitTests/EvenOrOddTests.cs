namespace EvenOrOdd.UnitTests;

public class EvenOrOddTests
{
    [TestCase(2, "Even")]
    [TestCase(4, "Even")]
    [TestCase(6, "Even")]
    [TestCase(1, "Odd")]
    [TestCase(3, "Odd")]
    [TestCase(5, "Odd")]
    public void ReturnCorrectAnswerForNumberType(int input, string expected)
    {
        Checker checker = new Checker();
        string result = checker.CheckNumber(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}