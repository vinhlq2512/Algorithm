public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = nums.Count() - 1;
        int[] ret = new int[2];
        for (int i = left; i <= right; i++)
        {
            for (int j = i + 1; j <= right; j++)
            {
                int a = nums[i];
                int b = nums[j];
                if (a + b == target)
                {
                    ret[0] = i;
                    ret[1] = j;
                    return ret;
                }
            }
        }
        return ret;
}
}