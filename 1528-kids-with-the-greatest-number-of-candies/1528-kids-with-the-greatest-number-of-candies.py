class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        largest = candies[0]
        for candidate in candies:
            if candidate > largest:
                largest = candidate
        
        result = [False] * len(candies)

        for i in range(len(candies)):
            result[i] = candies[i] + extraCandies >= largest
        
        return result