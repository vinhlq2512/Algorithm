public class Solution {
    public long MaxMatrixSum(int[][] matrix) 
    {
        long totalSum = 0;
        int minAbsVal = int.MaxValue;
        int negativeCount = 0;

        foreach (var row in matrix) 
        {
            foreach (var val in row) 
            {
                totalSum += Math.Abs(val);
                if (val < 0) 
                {
                    negativeCount++;
                }
                minAbsVal = Math.Min(minAbsVal, Math.Abs(val));
            }
        }
        if (negativeCount % 2 != 0) 
        {
            totalSum -= 2 * minAbsVal;
        }
        return totalSum;
    }
}