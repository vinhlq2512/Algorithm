class Solution:
    def countPrefixSuffixPairs(self, words: List[str]) -> int:
        res = 0

        def isPrefixAndSuffix(str1: str, str2: str) -> bool:
            return str2.startswith(str1) and str2.endswith(str1)

        for i in range(len(words)):
            for j in range(i + 1, len(words)):
                if isPrefixAndSuffix(words[i], words[j]):
                    res += 1

        return res