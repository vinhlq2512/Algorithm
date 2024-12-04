public class Solution {
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int i = 0, j = 0;
        int n = str1.Length;
        while (i < n && j < str2.Length)
        {
            if (str1[i] + 1 - str2[j] == 0 || str1[i] == str2[j] || (str1[i] - 24 - str2[j] == 1))
            {
                j++;
            }
            i++;
        }

        return j == str2.Length ? true : false;
    }
}