class Solution:
    def minimumRecolors(self, blocks: str, k: int) -> int:
        left = 0
        right = 0
        res = k
        recolor = 0
        n = len(blocks)
        while right < n:
            if blocks[right] == 'W':
                recolor += 1
            if right - left + 1 == k:
                res = min(res, recolor)
                if blocks[left] == 'W':
                    recolor -= 1
                left += 1

            right += 1
        return res