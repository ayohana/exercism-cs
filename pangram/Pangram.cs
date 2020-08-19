using System;
using System.Text;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return false;
        }

        int[] counter = new int[26]; // The elements of the array are initialized to the default value of the element type, 0 for integers.
        byte[] ASCIIValues = Encoding.ASCII.GetBytes(input.ToLower());
        for (int i = 0; i < ASCIIValues.Length; i++)
        {
            int index = ASCIIValues[i] - 97;
            if (index >= 0 && index < 26)
            {
                counter[index]++;
            }
        }

        for (int j = 0; j < counter.Length; j++)
        {
            if (counter[j] == 0)
            {
                return false;
            }
        }

        return true;
    }
}
