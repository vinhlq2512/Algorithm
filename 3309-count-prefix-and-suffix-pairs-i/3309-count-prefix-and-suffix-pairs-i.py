class Solution:
    def countPrefixSuffixPairs(self, words: List[str]) -> int:
        res = 0

        def isPrefixAndSuffix(str1: str, str2: str) -> bool:
            n = len(str1)
            for i in range(n):
                if str1[len(str1) - i - 1] != str2[len(str2) - 1 - i] or str1[i] != str2[i]:
                    return False
            return True

        for i in range(len(words)):
            for j in range(i + 1, len(words)):
                if len(words[i]) <= len(words[j]) and isPrefixAndSuffix(words[i], words[j]):
                    res += 1

        return res