class Solution:
    def check(self, nums: List[int]) -> bool:
        sorted_nums = sorted(nums)

        nums = nums * 2
        n = len(nums)
        index_sort = 0
        for i in range(n):
            if sorted_nums[index_sort] == nums[i]:
                index_sort = index_sort + 1
                if  index_sort == n / 2 or index_sort + 1== n / 2:
                    return True
            else:
                index_sort = 0

        return False