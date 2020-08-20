using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string output = "";
        char[] delimiters = new char[] { ' ', ',', '-', '_' };
        string[] words = phrase.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            output = output + words[i][0];
        }

        return output.ToUpper();
    }
}