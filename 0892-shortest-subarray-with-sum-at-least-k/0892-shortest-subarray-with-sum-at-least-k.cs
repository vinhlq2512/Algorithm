public class Solution {
    public int ShortestSubarray(int[] nums, int targetSum)
    {
        int n = nums.Length;

        long[] prefixSums = new long[n + 1];

        for (int i = 1; i <= n; i++)
        {
            prefixSums[i] = prefixSums[i - 1] + nums[i - 1];
        }

        var index = new LinkedList<int>();
        int minLength = int.MaxValue;

        for (int i = 0; i <= n; i++)
        {
            while (index.Count > 0 && prefixSums[i] - prefixSums[index.First.Value] >= targetSum)
            {
                minLength = Math.Min(minLength, i - index.First.Value);
                index.RemoveFirst();
            }

            // prevent element < 0 , prevent element dont make sum min
            while (index.Count > 0 && prefixSums[i] <= prefixSums[index.Last.Value])
            {
                index.RemoveLast();
            }

            index.AddLast(i);
        }

        return minLength == int.MaxValue ? -1 : minLength;
    }
}