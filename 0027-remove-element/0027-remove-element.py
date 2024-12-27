class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        totalSwaps = 0
        for i in range(len(nums)):
            if nums[i] != val:
                nums[totalSwaps] = nums[i]
                totalSwaps += 1
      
        print(nums)   
        return totalSwaps