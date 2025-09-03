class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        dictCheck = {}
        for i in nums:
            if i in dictCheck:
                return True
            dictCheck[i] = 1
        return False