class Solution:
    def mergeAlternately(self, word1: str, word2: str) -> str:
        length = max(len(word1), len(word2))
        result = ""
        while length > 0:
            if len(word1) > 0:
                result += word1[0]
                word1 = word1[1:]
            if len(word2) > 0:
                result += word2[0]
                word2 = word2[1:]
            length -= 1
            
        return result