public class Solution {
    public int MaximumLength(string s)
    {
        Dictionary<string, int> substringCount = new Dictionary<string, int>();
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                string substring = s.Substring(i, j - i);
                
                if (IsSpecial(substring))
                {
                    if (substringCount.ContainsKey(substring))
                        substringCount[substring]++;
                    else
                        substringCount[substring] = 1;
                }
            }
        }

        int longestLength = -1;
        foreach (var entry in substringCount)
        {
            if (entry.Value >= 3)
            {
                longestLength = Math.Max(longestLength, entry.Key.Length);
            }
        }

        return longestLength;
    }

    static bool IsSpecial(string s)
    {
        char firstChar = s[0];
        foreach (char c in s)
        {
            if (c != firstChar)
                return false;
        }
        return true;
    }
}