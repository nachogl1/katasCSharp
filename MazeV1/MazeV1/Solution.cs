namespace MazeV1;

public class Solution
{
    public static bool IsWalkable(string maze)
    {
        return !maze.Where((t, i) => !CanWalk(GetRoomSnapshot(maze, i))).Any();
    }

    private static bool CanWalk(string room)
    {
        return !room.Equals("o");
    }

    private static string GetRoomSnapshot(string maze, int i)
    {
        if(maze[i].ToString().Equals(" ")) return " ";
        
        return i % 2 == 0 ? maze[i].ToString() : GetUpdatedRoomType(maze, i);
    }

    private static string GetUpdatedRoomType(string maze, int i)
    {
        return maze[i].ToString().Equals("x") ? "o" : "x";
    }
}