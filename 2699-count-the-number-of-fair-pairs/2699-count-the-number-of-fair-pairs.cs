public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper)
{
    Array.Sort(nums);
    return countPairs(nums, upper) - countPairs(nums, lower - 1);
}

public long countPairs(int[] nums, int upper)
{
    int left = 0;
    int right = nums.Length - 1;
    long res = 0;
    while (left < right)
    {
        if (nums[left] + nums[right] <= upper)
        {
            res += right - left;
            left++;
        }
        else
        {
            right--;
        }

    }
    return res;
}
}