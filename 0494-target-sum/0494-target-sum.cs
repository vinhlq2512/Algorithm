public class Solution
{
    private int totalWays = 0;

    public int FindTargetSumWays(int[] nums, int target)
    {
        CalculateWays(nums, 0, 0, target);
        return totalWays;
    }

    private void CalculateWays(int[] nums, int currentIndex, int currentSum, int target)
    {
        if (currentIndex == nums.Length)
        {
            if (currentSum == target)
            {
                totalWays++;
            }
        }
        else
        {
            CalculateWays(nums, currentIndex + 1, currentSum + nums[currentIndex], target);
            CalculateWays(nums, currentIndex + 1, currentSum - nums[currentIndex], target);
        }
    }
}