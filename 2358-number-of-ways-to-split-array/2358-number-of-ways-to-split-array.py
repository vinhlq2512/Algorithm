class Solution:
    def waysToSplitArray(self, nums: list[int]) -> int:
        n = len(nums)
        pref_sum = [0] * n
        pref_sum[0] = nums[0]

        for i in range(1, n):
            pref_sum[i] = pref_sum[i - 1] + nums[i]

        count = 0 

        for i in range(n - 1):
            left_sum = pref_sum[i]  
            right_sum = pref_sum[-1] - pref_sum[i]  

            if left_sum >= right_sum:  
                count += 1  
                
        return count