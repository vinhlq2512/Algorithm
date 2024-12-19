public class Solution {
    public int MaxChunksToSorted(int[] arr)
    {
        int n = arr.Length;
        int chunks = 0, maxElement = 0;

        for (int i = 0; i < n; i++)
        {
            maxElement = Math.Max(maxElement, arr[i]);

            if (maxElement == i)
            {
                chunks++;
            }
        }

        return chunks;
    }
}