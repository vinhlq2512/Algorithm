public class Solution {
    public int TakeCharacters(string s, int k)
    {
        Dictionary<char, int> count = new Dictionary<char, int> { { 'a', 0 }, { 'b', 0 }, { 'c', 0 } };
        int n = s.Length;

        foreach (char c in s)
        {
            count[c]++;
        }

        if (count.Any(pair => pair.Value < k))
            return -1;

        Dictionary<char, int> window = new Dictionary<char, int> { { 'a', 0 }, { 'b', 0 }, { 'c', 0 } };

        int left = 0, maxWindow = 0;

        for (int right = 0; right < n; right++)
        {
            char currentChar = s[right];

            window[currentChar]++;

            while (left <= right &&
                   (count['a'] - window['a'] < k ||
                    count['b'] - window['b'] < k ||
                    count['c'] - window['c'] < k))
            {
                char leftChar = s[left];
                window[leftChar]--;
                left++;
            }
            maxWindow = Math.Max(maxWindow, right - left + 1);
        }

        return n - maxWindow;
    }
}