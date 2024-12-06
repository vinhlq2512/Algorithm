public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        int start = 1;
        int count = 0;

        while (start <= n)
        {
            if (!isBanned(banned, start))
            {
                maxSum = maxSum - start;
                if (maxSum < 0)
                {
                    break;
                }
                count++;

            }

            start++;
        }
        return count;
    }
    public bool isBanned(int[] banned, int number)
    {
        for (int i = 0; i < banned.Length; i++)
        {
            if (banned[i] == number)
            {
                return true;
            }
        }
        return false;
    }
}