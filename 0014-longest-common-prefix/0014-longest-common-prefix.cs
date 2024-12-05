public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = int.MaxValue;
        string strCompare = "";

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < minLength)
            {
                minLength = strs[i].Length;
                strCompare = strs[i];
            }
        }
        StringBuilder sb = new StringBuilder(minLength);

        for (int i = 0; i < strCompare.Length; i++)
        {
            sb.Append(strCompare[i]);
            for (int j = 0; j < strs.Length; j++)
            {
                if (!strs[j][i].Equals(sb[i]))
                {
                    return sb.Remove(sb.Length - 1, 1).ToString();
                }
            }
        }
        return sb.ToString();
    }
}