public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = int.MaxValue;
        string strCompare = strs[0];

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < strCompare.Length; i++)
        {
            sb.Append(strCompare[i]);
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length  || !strs[j][i].Equals(sb[i]) )
                {
                    return sb.Remove(sb.Length - 1, 1).ToString();
                }
            }
        }
        return sb.ToString();
    }
}