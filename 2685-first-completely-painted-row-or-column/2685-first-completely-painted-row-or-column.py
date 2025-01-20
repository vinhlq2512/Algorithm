class Solution:
    def firstCompleteIndex(self, arr: List[int], mat: List[List[int]]) -> int:
        rows, cols = len(mat), len(mat[0])

        value_to_index = {mat[i][j]: (i, j) for i in range(rows) for j in range(cols)}

        row_count = [0] * rows
        col_count = [0] * cols

        for idx, value in enumerate(arr):
            if value in value_to_index:
                x, y = value_to_index[value]

                row_count[x] += 1
                col_count[y] += 1

                if row_count[x] == cols or col_count[y] == rows:
                    return idx

        return -1