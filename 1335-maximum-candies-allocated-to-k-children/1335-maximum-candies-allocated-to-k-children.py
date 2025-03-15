class Solution:
    def maximumCandies(self, candies, k):
        if sum(candies) < k:  
            return 0  

        left, right = 1, max(candies)
        
        while left < right:
            mid = (left + right + 1) // 2  
            count = sum((c - (c % mid)) // mid for c in candies) 

            if count >= k:
                left = mid  
            else:
                right = mid - 1  
        
        return left