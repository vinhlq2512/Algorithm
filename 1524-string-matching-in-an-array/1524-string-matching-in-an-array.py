class Solution:
    def stringMatching(self, words: List[str]) -> List[str]:
        res = set()
        for word in words:
            for other in words:
                if len(word) < len(other) and word in other:
                    res.add(word)
        return list(res)