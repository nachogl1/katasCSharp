namespace StringManipulation1;

public class Solution
{
    public string Remove(string input)
    {
        if(input.Length < 3) return input;
        return input.Substring(1, input.Length - 1).Substring(0, input.Length - 2);
    }
}