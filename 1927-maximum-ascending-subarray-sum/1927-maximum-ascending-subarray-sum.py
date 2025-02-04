class Solution:
    def maxAscendingSum(self, nums: List[int]) -> int:
        res = 0
        n = len(nums)
        max_sum = 0
        is_decreasing = False
        if n == 1:
            return nums[0]

        for i in range(1, n):
            if nums[i - 1] < nums[i]:
                if is_decreasing:
                    max_sum += nums[i]
                else:
                    max_sum = nums[i] + nums[i - 1]

                is_decreasing = True

            else:
                max_sum = nums[i - 1]
                is_decreasing = False

            res = max(res, max_sum)

        return res