public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
    
        for (int i = 0; i < k; i++)
        {
            int min = int.MaxValue;
            int idx = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < min)
                {
                    min = nums[j];
                    idx = j;
                }
            }
            nums[idx] = min * multiplier;
        }

        return nums;
    }
}