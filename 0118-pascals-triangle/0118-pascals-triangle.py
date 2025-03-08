class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        res = [0] * numRows
        for i in range(numRows):
            res[i] = [0] * (i + 1)

        res[0][0] = 1
        for i in range(numRows):
            len_row = i + 1
            for j in range(len_row):
                if j == 0 or j == len_row-1:
                    res[i][j] = 1
                else:
                    res[i][j] = res[i-1][j] + res[i-1][j-1]

        return res