public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        int n = searchWord.Length;
        string[] splited = sentence.Split(' ');

        for (int i = 0; i < splited.Length; i++)
        {
            int j = 0;
            while (j < n && splited[i].Length >= n)
            {
                if (searchWord[j] != splited[i][j])
                    break;
                j++;
                if (j == n)
                {
                    return i + 1;
                }
            }

        }

        return -1;
    }
}