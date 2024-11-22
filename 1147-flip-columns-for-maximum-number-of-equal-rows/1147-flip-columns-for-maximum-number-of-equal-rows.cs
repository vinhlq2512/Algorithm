public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (int[] row in matrix)
        {
            string key = "";
            for (int j = 0; j < row.Length; j++)
            {
                if (row[0] == row[j])
                {
                    key += "T";
                }
                else
                {
                    key += "F";
                }
            }
            if (dic.ContainsKey(key))
            {
                dic[key]++;
            }
            else
            {
                dic.Add(key,1);
            }
        }
        return dic.Values.Max();
    }


}