public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        Array.Sort(banned);
        int start = 1;
        int count = 0;

        while (start <= n)
        {
            if (!IsBanned(banned, start))
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


    public bool IsBanned(int[] banned, int number)
    {
        int left = 0, right = banned.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (banned[mid] == number)
            {
                return true;
            }
            else if (banned[mid] < number)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}