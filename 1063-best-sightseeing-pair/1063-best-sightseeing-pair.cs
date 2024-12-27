public class Solution {
    public int MaxScoreSightseeingPair(int[] values)
    {
        int max = int.MinValue;
        int n = values.Length;
        int preMax = values[0];

        for (int i = 1; i < n; i++)
        {
            max = Math.Max(max, preMax + values[i] - i);
            preMax = Math.Max(preMax, values[i] + i);
        }

        return max;
    }
}