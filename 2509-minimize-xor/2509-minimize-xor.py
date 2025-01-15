class Solution:
    def minimizeXor(self, num1: int, num2: int) -> int:
        setBitsNum2 = bin(num2).count('1')
    
        x = 0
        setBitsX = 0
        
        for i in range(31, -1, -1):  
            if setBitsX < setBitsNum2 and (num1 & (1 << i)):
                x |= (1 << i)
                setBitsX += 1
        
   
        for i in range(32):
            if setBitsX < setBitsNum2 and not (x & (1 << i)):
                x |= (1 << i)
                setBitsX += 1
        
        return x