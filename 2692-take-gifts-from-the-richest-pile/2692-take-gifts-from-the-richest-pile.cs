public class Solution {
     public long PickGifts(int[] gifts, int k)
    {
        int n = gifts.Length;
        for (int i = 0; i < k; i++)
        {
            int maxIndex = 0;
            for (int j = 0; j < n; j++)
            {
                if (gifts[j] > gifts[maxIndex])
                {
                    maxIndex = j;
                }
            }
            gifts[maxIndex] = (int)Math.Floor(
                Math.Sqrt(gifts[maxIndex])
            );
        }

        long sum = gifts.Sum(x => (long)x);
        return sum;
    }
}