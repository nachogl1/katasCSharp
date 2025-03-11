using System.Numerics;

namespace WheatProblem.UnitTests;

public class SolutionTests
{

    [TestCase("1", 1)]
    [TestCase("2", 2)]
    [TestCase("3", 2)]
    [TestCase("4", 3)]
    [TestCase("5", 3)]
    [TestCase("16", 5)]
    [TestCase("17", 5)]
    [TestCase("549755813888", 40)]
    public void CalculateMySquare(string grain, int room)
    {
        int result = Solution.GetRoomFromGrain(BigInteger.Parse(grain));
        Assert.That(result, Is.EqualTo(room));
    }
}