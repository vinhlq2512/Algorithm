class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        n = len(nums)
        pre = nums[0]
        for i in range(1, n):
            pre += nums[i]
            nums[i] = pre
        return nums