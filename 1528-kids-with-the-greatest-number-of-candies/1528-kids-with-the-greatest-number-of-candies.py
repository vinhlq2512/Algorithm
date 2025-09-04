class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        largest = max(candies)
        
        result = [False] * len(candies)

        for i in range(len(candies)):
            result[i] = candies[i] + extraCandies >= largest
        
        return result