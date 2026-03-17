class Solution:
    def minStartValue(self, nums: List[int]) -> int:
        n = 1
        while True:
            prefix_sum = n
            valid = True
            for num in nums:
                prefix_sum += num
                if prefix_sum < 1:
                    valid = False
                    break
            if valid:
                return n
            n += 1