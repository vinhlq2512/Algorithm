class Solution:
    def minStartValue(self, nums: List[int]) -> int:
        n = 1
        length = len(nums)
        while True:
            check = True
            pre =[0] * (length + 1)
            pre[0] = n
            for i in range(length):
                pre[i + 1] = pre[i] + nums[i]
                print("pre[{}] = pre[{}] + nums[{}]".format(i + 1, i, i))
                print("pre[{}] = {} + {}".format(i + 1, pre[i], nums[i]))
                if pre[i + 1] < 1:
                    check = False
                    break

            if check:
                return n
            else:
                n = n + 1