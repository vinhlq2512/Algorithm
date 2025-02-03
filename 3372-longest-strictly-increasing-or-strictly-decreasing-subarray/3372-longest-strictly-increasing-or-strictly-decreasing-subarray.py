class Solution:
    def longestMonotonicSubarray(self, nums: List[int]) -> int:

        n = len(nums)
        is_increasing = False
        max_length = 1
        res = 1

        for i in range(n - 1):
            if nums[i] > nums[i + 1]:
                if is_increasing:
                    is_increasing = False
                    max_length = 2
                else:
                    max_length += 1
            elif nums[i] < nums[i + 1]:
                if is_increasing:
                    max_length += 1
                else:
                    max_length = 2
                    is_increasing = True
            else:
                is_increasing = False
                max_length = 1

            res = max(res, max_length)

        return res