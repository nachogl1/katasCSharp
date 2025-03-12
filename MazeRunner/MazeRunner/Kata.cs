namespace MazeRunner;

public class Kata
{
    public string MazeRunner(int[,] maze, string[] directions)
    {
        var (startingY, startingX) = GetStartingIndex(maze);
        try
        {
            return ComputeAnswer(maze, directions, startingY, startingX);
        }
        catch (IndexOutOfRangeException e)
        {
            return "Dead";
        }
    }

    private string ComputeAnswer(int[,] maze, string[] directions, int y, int x)
    {
        if (maze[y, x] == 3) return "Finish";
        if (maze[y, x] == 1) return "Dead";
        if (directions.Length == 0) return "Lost";

        (int newY, int newX, string[] newDirections) = ProcessNewDirections(directions, y, x);

        return ComputeAnswer(maze, newDirections, newY, newX);
    }

    private (int newY, int newX, string[] newDirections) ProcessNewDirections(string[] directions, int y, int x)
    {
        if (directions.GetValue(0)!.Equals("N")) y--;
        if (directions.GetValue(0)!.Equals("S")) y++;
        if (directions.GetValue(0)!.Equals("E")) x++;
        if (directions.GetValue(0)!.Equals("W")) x--;

        string[] newDirections = directions.Skip(1).ToArray();

        return (y, x, newDirections);
    }

    private (int x, int y) GetStartingIndex(int[,] maze)
    {
        int max = maze.GetLength(0);
        for (int y = 0; y < max; y++)
        {
            for (int x = 0; x < max; x++)
            {
                if (maze[y, x] == 2)
                {
                    return (y, x);
                }
            }
        }

        throw new Exception("Starting point not found");
    }
}