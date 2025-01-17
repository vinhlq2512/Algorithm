class Solution:
    def doesValidArrayExist(self, derived: List[int]) -> bool:
        res = 0
        for n in derived:
            res ^= n
        
        return res == 0