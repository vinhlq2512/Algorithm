public class Solution {
    public int MinimumSize(int[] nums, int maxOperations)
    {
        int left = 1;
        int right = nums.Max();

        while (left < right)
        {
            int middle = (left + right) / 2;

            if (IsPossible(middle, nums, maxOperations))
            {
                right = middle; 
            }
            else
            {
                left = middle + 1; 
            }
        }

        return left;
    }

    private bool IsPossible(int maxBallsInBag, int[] nums, int maxOperations)
    {
        int totalOperations = 0;

        foreach (int num in nums)
        {
            int operations = (int)Math.Ceiling(num / (double)maxBallsInBag) - 1;
            totalOperations += operations;

            if (totalOperations > maxOperations)
            {
                return false;
            }
        }

        return true;
    }
}