class Solution:
    def stringMatching(self, words: List[str]) -> List[str]:
            def isContain(word: str, words: List[str]) -> bool:
                for other in words:
                    if word != other and word in other:
                        return True
                return False

            res = []
            for word in words:
                if isContain(word, words):
                    res.append(word)
            return res