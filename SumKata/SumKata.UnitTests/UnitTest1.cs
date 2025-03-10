namespace SumKata.UnitTests;

public class Tests
{
    private Solution _solution;

    [SetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [TestCase(new[] { -1, 2, -3, -4, -5, -6, -7, -8, -9 }, 2)]
    [TestCase(new[] { -1, 2, 3, -4, -5, -6, -7, -8, -9 }, 5)]
    [TestCase(new[] { 1, 2, 3 }, 6)]
    public void AddOnlyPositiveNumbers(int[] input, int expected)
    {
        var result = _solution.Add(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}