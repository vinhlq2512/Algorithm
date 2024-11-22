public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int res = int.MinValue;
        Dictionary<string, int> dic = new Dictionary<string, int>();

    
        for (int i = 0; i < rows; i++)
        {
            string key1 = "";
            string key2 = "";
            for (int j = 0; j < cols; j++)
            {
                 key1 += matrix[i][j].ToString();
                 
                 int keyStr = matrix[i][j] ^ 1;
                 key2 += keyStr.ToString();
            }
            if (dic.ContainsKey(key1))
            {
                dic[key1]++;
            }
            else
            {
                dic.Add(key1,1);
            }
            
            if (dic.ContainsKey(key2))
            {
                dic[key2]++;
            }
            else
            {
                dic.Add(key2,1);
            }
        }
        
        return dic.Values.Max();
    }

}