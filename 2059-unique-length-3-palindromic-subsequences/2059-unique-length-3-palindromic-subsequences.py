class Solution:
    def countPalindromicSubsequence(self, s: str) -> int:
        res = set()
        left = set()
        right = Counter(s)

        for c in s:
            right[c] -= 1
            for c_left in left:
                if right[c_left] > 0:
                    res.add((c, c_left))
            left.add(c)
        return len(res)