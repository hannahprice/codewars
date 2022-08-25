using System;
using System.Linq;

public static class Kata
{
    private const string vowels = "aeiou";

    public static int GetVowelCount(string str)
    {
        var vowelCharacters = vowels.ToCharArray();
        var stringCharacters = str.Trim().ToCharArray();
        return stringCharacters.Count(x => vowelCharacters.Contains(x));
    }
}
