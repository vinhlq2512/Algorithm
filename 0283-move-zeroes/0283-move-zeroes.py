class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        queue = deque()
        
        for num in nums:
            if num != 0:
                queue.append(num)
        
        for i in range(len(nums)):
            if queue:
                nums[i] = queue.popleft()
            else:
                nums[i] = 0