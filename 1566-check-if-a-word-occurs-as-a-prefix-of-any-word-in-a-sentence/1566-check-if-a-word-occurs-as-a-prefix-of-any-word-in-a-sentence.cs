public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord)
    {

        string[] splited = sentence.Split(' ');

        for (int i = 0; i < splited.Length; i++)
        {
            if (splited[i].StartsWith(searchWord))
            {
                return i + 1; 
            }
        }

        return -1;
    }
}