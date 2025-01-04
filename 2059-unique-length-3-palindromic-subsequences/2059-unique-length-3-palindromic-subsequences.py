class Solution:
    def countPalindromicSubsequence(self, s: str) -> int:
        res = set()
        left = set()
        right = Counter(s)

        for c in s:
            right[c] -= 1
            for j in left:
                if right[j] > 0:
                    res.add(j + c)
            left.add(c)
        return len(res)