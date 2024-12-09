public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        int n = nums.Length;
        bool[] valid = new bool[n - 1];
        int[] prefixSum = new int[n];

        for (int i = 0; i < n - 1; i++)
        {
            valid[i] = nums[i] % 2 != nums[i + 1] % 2; 
            prefixSum[i + 1] = prefixSum[i] + (valid[i] ? 1 : 0);
        }
    
        bool[] res = new bool[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0];
            int end = queries[i][1]; 
        
            int rangeLength = end - start; 
            int alternatingCount = prefixSum[end] - prefixSum[start];
            res[i] = (alternatingCount == rangeLength);
        }
    
        return res;
    }
}