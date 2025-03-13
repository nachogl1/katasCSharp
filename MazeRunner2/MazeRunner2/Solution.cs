namespace MazeRunner2;

public class Solution
{
    public static bool CheckForPath(char[][] maze, int startX, int startY, int endX, int endY)
    {
        if (endX >= maze.Length || endY >= maze.Length)
            throw new Exception("ay ay ay the end point is outside of the maze");

        return HasPath(maze, startX, startY, endX, endY, new bool[maze.Length,maze[0].Length]);
    }

    private static bool HasPath(char[][] maze, int x, int y, int endX, int endY,  bool[,] visited)
    {
        if (x >= maze.Length || y >= maze.Length || x <0 || y<0) return false;
        
        if(visited[x, y]) return false;
        
        visited[x, y] = true;
        
        if (maze[x][y] == '#') return false;
        
        if(x == endX && y == endY) return true;
        
        return HasPath(maze, x, y+1, endX, endY, visited) ||
               HasPath(maze, x, y-1, endX, endY, visited) ||
               HasPath(maze, x+1, y, endX, endY, visited) ||
               HasPath(maze, x-1, y, endX, endY, visited);
    }
}