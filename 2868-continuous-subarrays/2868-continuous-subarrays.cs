public class Solution {
    public long ContinuousSubarrays(int[] nums)
    {
        int n = nums.Length;
        long res = 0;

        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

        for (int l = 0, r = 0; r < n; r++)
        {
            if (dic.ContainsKey(nums[r]))
            {
                dic[nums[r]]++;
            }
            else
            {
                dic[nums[r]] = 1;
            }

            while (l < r && dic.Last().Key - dic.First().Key > 2)
            {
                dic[nums[l]]--;

                if (dic[nums[l]] == 0)
                {
                    dic.Remove(nums[l]);
                }

                l++;
            }
            res += r - l + 1L;
        }

        return res;
    }
}