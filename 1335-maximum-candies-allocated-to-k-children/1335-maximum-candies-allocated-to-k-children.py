class Solution:
    def maximumCandies(self, candies, k):
        max_candies = 0
        for candie in candies:
            max_candies = max(max_candies, candie)

        left = 0
        right = max_candies
        while left < right:
            mid = (left + right + 1) // 2
            if self.can_allocate(candies, k, mid):
                left = mid
            else:
                right = mid - 1

        return left

    def can_allocate(self, candies: List[int], k: int, number_candies: int) -> bool:
        max_children = 0
        for candie in candies:
            max_children += candie // number_candies

        return max_children >= k