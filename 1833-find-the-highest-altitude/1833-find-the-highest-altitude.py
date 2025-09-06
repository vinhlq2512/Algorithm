class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        res = 0
        prefixSum = [0] * (len(gain) + 1)
        for i in range(1, len(gain) + 1):
            prefixSum[i] = prefixSum[i - 1] + gain[i - 1]
            res = max(res, prefixSum[i])
        
        return res