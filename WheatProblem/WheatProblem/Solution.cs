using System.Numerics;

namespace WheatProblem;

public class Solution
{
    public static int GetRoomFromGrain(BigInteger grain)
    {
        return CalculateRoom(grain, 1);
    }

    private static int CalculateRoom(BigInteger grain, int square)
    {
        if (grain <= 1) return square;
        return CalculateRoom(BigInteger.Divide(grain, 2), ++square);
    }
}