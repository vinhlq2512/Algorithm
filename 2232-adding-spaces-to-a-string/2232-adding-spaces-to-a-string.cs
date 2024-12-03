public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder res = new StringBuilder();
        int n = s.Length;
        int i = 0;
        int j = 0;
        while (i < n)
        {
            if ( j < spaces.Length && i == spaces[j])
            {
                res.Append(" " );
                j++;
            }
            res.Append(s[i]);
            i++;
        }

        return res.ToString();
    }
}