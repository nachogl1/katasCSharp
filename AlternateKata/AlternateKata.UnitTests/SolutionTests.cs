namespace AlternateKata.UnitTests;

public class SolutionTests
{

    [TestCase("amazon",true)]
    [TestCase("mazon",true)]
    [TestCase("banana",true)]
    [TestCase("aamazon",false)]
    [TestCase("apple",false)]
    [TestCase("hceab",false)]
    public void ReturnTruIfAlternate(string input, bool expected)
    {
        Assert.That(Solution.IsAlternate(input), Is.EqualTo(expected));
    }
}