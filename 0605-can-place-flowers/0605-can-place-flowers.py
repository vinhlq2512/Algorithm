class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        if(len(flowerbed) == 1):
            if flowerbed[0] == 0 and n <= 1:
                return True
            elif flowerbed[0] == 1 and n == 0:
                return True
            else:
                return False
            
        count = 0
        i = 0
        while i < len(flowerbed):
          if (i == 0 and flowerbed[i+ 1] == 0) or (i == len(flowerbed) - 1 and flowerbed[i - 1] == 0) or (flowerbed[i - 1] == 0 and flowerbed[i + 1] == 0):
            if flowerbed[i] == 0:
              flowerbed[i] = 1
              count += 1

          i+= 1

          if count >= n:
             return True

        return False
