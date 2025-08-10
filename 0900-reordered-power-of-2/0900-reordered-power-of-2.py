class Solution:
    def reorderedPowerOf2(self, n: int) -> bool:

        precompute = [1 << i for i in range(31)]
        n_sorted = sorted(str(n))
        for num in precompute:
            if sorted(str(num)) == n_sorted:
                return True

        return False