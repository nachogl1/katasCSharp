namespace AlternateKata;

public class Solution
{
    private static HashSet<char> _vowels = ['a', 'e', 'i', 'o', 'u'];

    public static bool IsAlternate(string input)
    {
        char firstCharacter = Char.Parse(input.Substring(0, 1));
        return Recursive(input, 0, _vowels.Contains(firstCharacter));
    }

    private static bool Recursive(string input, int index, bool isFirstVowel)
    {
        if (input.Length == index) return true;

        if (index % 2 == 0 && isFirstVowel && !_vowels.Contains(input[index])) return false;
        if (index % 2 == 0 && !isFirstVowel && _vowels.Contains(input[index])) return false;
        if (index % 2 != 0 && isFirstVowel && _vowels.Contains(input[index])) return false;
        if (index % 2 != 0 && !isFirstVowel && !_vowels.Contains(input[index])) return false;

        return Recursive(input, ++index, isFirstVowel);
    }
}