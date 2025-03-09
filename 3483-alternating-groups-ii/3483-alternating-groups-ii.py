class Solution:
    def numberOfAlternatingGroups(self, colors: List[int], k: int) -> int:
        colors = colors + colors[:k - 1] 
        res = 0
        left = 0

        for right in range(1, len(colors)):
            if colors[right] == colors[right - 1]:
                left = right

            if right - left + 1 == k:
                res += 1
                left += 1  

        return res