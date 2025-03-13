namespace MazeRunner2.UnitTests;

public class SolutionTests
{
    private readonly char[][] _maze =
    [
        [' ', '#', ' ', ' ', ' ', ' ', ' '],
        [' ', '#', ' ', '#', '#', '#', ' '],
        [' ', '#', ' ', '#', '#', ' ', ' '],
        [' ', '#', ' ', '#', '#', ' ', '#'],
        [' ', '#', ' ', '#', '#', ' ', ' '],
        [' ', ' ', ' ', '#', '#', '#', ' '],
        ['#', ' ', '#', ' ', '#', ' ', ' ']
    ];
    
    private readonly char[][] _maze2 =
    [
        [' ', '#', ' ', ' ', ' ', ' ', ' '],
        [' ', '#', ' ', '#', '#', '#', '#'],
        [' ', '#', ' ', '#', '#', ' ', ' '],
        [' ', '#', ' ', '#', '#', ' ', '#'],
        [' ', '#', ' ', '#', '#', ' ', ' '],
        [' ', ' ', ' ', '#', '#', '#', ' '],
        ['#', ' ', '#', ' ', '#', ' ', ' ']
    ];

    private const int StartX = 0;
    private const int StartY = 0;
    private const int EndX = 6;
    private const int EndY = 6;

    [Test]
    public void ReturnTrueForPath()
    {
        Assert.That(Solution.CheckForPath(_maze, StartX, StartY, EndX, EndY), Is.True);
    }
    
    [Test]
    public void ReturnFalseForPath()
    {
        Assert.That(Solution.CheckForPath(_maze2, StartX, StartY, EndX, EndY), Is.False);
    }
}