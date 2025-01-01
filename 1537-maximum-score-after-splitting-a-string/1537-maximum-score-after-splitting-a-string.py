class Solution:
    def maxScore(self, s: str) -> int:
        maxVal = 0
        count_one = 0
        count_zero = 0

        for i in range(len(s)):
            if s[i] == '1':
                count_one += 1


        for i in range(len(s) - 1):
            if s[i] == '0':
                count_zero += 1
            else:
                count_one -= 1

            maxVal = max(maxVal, count_zero + count_one)

        return maxVal