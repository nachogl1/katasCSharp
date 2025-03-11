namespace GCD;

public class Solution
{
    public static int Gcd(int x, int y)
    {
        return y == 0 ? x : Gcd(y, x % y);
    }
}