public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int res = int.MinValue;
        Dictionary<string, int> dic = new Dictionary<string, int>();

    
        for (int i = 0; i < rows; i++)
        {
            string key = "";
            for (int j = 0; j < cols; j++)
            {
                 key += matrix[i][j].ToString();
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
        
        for (int i = 0; i < rows; i++)
        {
            string key = "";
            for (int j = 0; j < cols; j++)
            {
                int keyStr = matrix[i][j] == 1 ? 0 : 1;
                key += keyStr.ToString();
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