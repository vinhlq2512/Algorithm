public class Solution {
    public long MaximumSubarraySum(int[] nums, int k)
    {
        int n = nums.Length;
        if (n < k) return 0; 

        long maxSum = 0;      
        long currentSum = 0;   
        HashSet<int> set = new HashSet<int>();

        int left = 0;        

        for (int right = 0; right < n; right++)
        {
           
            while (set.Contains(nums[right]))
            {
                set.Remove(nums[left]);
                currentSum -= nums[left];
                left++;
            }

          
            set.Add(nums[right]);
            currentSum += nums[right];

            if (right - left + 1 == k)
            {
                maxSum = Math.Max(maxSum, currentSum);

                set.Remove(nums[left]);
                currentSum -= nums[left];
                left++;
            }
        }

        return maxSum;
    }
}