class Solution:
    def areAlmostEqual(self, s1: str, s2: str) -> bool:
        index = []
        n = len(s1)
        for i in range(n):
            if s1[i] != s2[i]:
                index.append(i)
            if len(index) > 2:
                return False
        if len(index) == 2:
            i = index[0]
            j = index[1]
            return s1[i] == s2[j] and s1[j] == s2[i]
        
        return len(index) == 0