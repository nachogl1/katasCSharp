namespace SumKata;

public class Solution
{
    private List<int> FilterPositives(int[] input)
    {
        return input.Where(number => number > 0).ToList();
    }

    public int Add(int[] input)
    {
        List<int> positives = FilterPositives(input);
        return positives.Sum();
    }
}