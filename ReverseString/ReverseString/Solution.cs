﻿namespace ReverseString;

public class Solution
{
    public static string Reverse(string input)
    {
        string result = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result += input[i];
        }

        return result;
    }
}