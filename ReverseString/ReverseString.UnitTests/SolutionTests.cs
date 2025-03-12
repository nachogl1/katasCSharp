namespace ReverseString.UnitTests;

public class SolutionTests
{
    [TestCase("hola", "aloh")]
    [TestCase("arte suave", "evaus etra")]
    public void ReturnReversedString(string input, string expected)
    {
        string result = Solution.Reverse(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}