class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        n = len(nums)
        prefix_sum_left = [0]*n
        prefix_sum_right = [0]*n

        prefix_sum_left[0] = nums[0]
        for i in range(1, n):
            prefix_sum_left[i] = prefix_sum_left[i-1] + nums[i]

        prefix_sum_right[n-1] = nums[n-1]
        for i in range(n-2, -1, -1):
            prefix_sum_right[i] = prefix_sum_right[i+1] + nums[i]


        for i in range(n):
            left_sum = prefix_sum_left[i] - nums[i]
            right_sum = prefix_sum_right[i] - nums[i]
            if left_sum == right_sum:
                return i
        return -1