namespace MazeV1.UnitTests;

public class SolutionTests

{
    [Test]
    public void ReturnTrueForXEmpty()
    {
        bool result = Solution.IsWalkable("x ");
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void ReturnFalseForXx()
    {
        bool result = Solution.IsWalkable("xx");
        Assert.That(result, Is.EqualTo(false));
    }

    [TestCase("o", false)]
    [TestCase(" ", true)]
    [TestCase("x", true)]
    [TestCase("xo oxox", true)]
    [TestCase("xo  oxox", false)]
    [TestCase("xo oxox", true)]
    [TestCase("xo  oxox", false)]
    [TestCase("xo ox xo", true)]
    [TestCase("xooxxo", false)]
    [TestCase("xxxxxx", false)]
    [TestCase("oooooo", false)]
    [TestCase("      ", true)]
    [TestCase(" ox", true)]
    [TestCase("xo", true)]
    [TestCase("x", true)]
    [TestCase("o", false)]
    public void ReturnIfWalkable(string input, bool expected)
    {
        bool result = Solution.IsWalkable(input);
        Assert.That(expected, Is.EqualTo(result));
    }
}