public class Solution {
    public int MaximumBeauty(int[] nums, int k)
    {
        Array.Sort(nums);
        int right = 0; 
        int max = 0;

        for (int left = 0; left < nums.Length; left++)
        {
            while (right < nums.Length && nums[right] - nums[left] <= 2 * k)
            {
                right++;
            }
            max = Math.Max(max, right - left);
        }

        return max;
    }
}