public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] res = new int[n];

        if (k == 0)
        {
            for (int i = 0; i < code.Length; i++)
            {
                res[i] = 0;
            }
        }
        else
        {
            int step = k < 0 ? k * -1 : k;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= step; j++)
                {
                    int index = k > 0 ? i + j : i -j;
                    if (index < 0)
                    {
                        index += n;
                    }
                    
                    if(index >= n)
                    {
                        index -= n;
                    }
                    res[i] += code[index];
                }
            }
        }
        return res;
    }
}