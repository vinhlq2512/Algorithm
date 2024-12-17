public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        int[] freq = new int[26];
        foreach (char ch in s)
        {
            freq[ch - 'a']++;
        }

        StringBuilder result = new StringBuilder();
        int currentCharIndex = 25;

        while (currentCharIndex >= 0)
        {
            if (freq[currentCharIndex] == 0)
            {
                currentCharIndex--;
                continue;
            }

            int use = Math.Min(freq[currentCharIndex], repeatLimit);
            for (int k = 0; k < use; k++)
            {
                result.Append((char) ('a' + currentCharIndex));
            }
            freq[currentCharIndex] -= use;

            if (freq[currentCharIndex] > 0) 
            {
                int smallerCharIndex = currentCharIndex - 1;
                while (smallerCharIndex >= 0 && freq[smallerCharIndex] == 0)
                {
                    smallerCharIndex--;
                }
                if (smallerCharIndex < 0)
                {
                    break;
                }
                result.Append((char) ('a' + smallerCharIndex));
                freq[smallerCharIndex]--;
            }
        }

        return result.ToString();
    }
}