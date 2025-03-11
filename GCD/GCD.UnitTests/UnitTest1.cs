namespace GCD.UnitTests;

[TestFixture]
public class GcdUnitTests
{
    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 1)]
    [TestCase(2, 2, 2)]
    [TestCase(4, 2, 2)]
    [TestCase(4, 4, 4)]
    [TestCase(30, 12, 6)]
    [TestCase(8, 9, 1)]
    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 1)]
    [TestCase(10, 5, 5)]
    [TestCase(100, 25, 25)]
    [TestCase(48, 18, 6)]
    [TestCase(81, 27, 27)]
    [TestCase(17, 13, 1)]
    [TestCase(56, 98, 14)]
    [TestCase(270, 192, 6)] 
    [TestCase(144, 12, 12)]
    public void ReturnGcdOf(int x, int y, int expected)
    {
        int result = Solution.Gcd(x, y);
        Assert.That(result, Is.EqualTo(expected));
    }
}