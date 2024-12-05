public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder sb = new StringBuilder();

        string strCompare = strs[0];
        for (int i = 0; i < strCompare.Length; i++)
        {
            sb.Append(strCompare[i]);
            for (int j = 1; j < strs.Length; j++)
            {
                if (!strs[j].StartsWith(sb.ToString()))
                {
                    return sb.Remove(sb.Length - 1, 1).ToString();
                }
            }
        }
        return sb.ToString();
    }
}