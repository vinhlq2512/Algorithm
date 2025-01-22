class Solution:
    def highestPeak(self, isWater: List[List[int]]) -> List[List[int]]:
        ROW = len(isWater)
        COL = len(isWater[0])
        q = deque() # (row, col)

        res = [[-1 for _ in range(COL)] for _ in range(ROW)]

        for r in range(ROW):
            for c in range(COL):
                if isWater[r][c] == 1:
                    q.append((r, c))
                    res[r][c] = 0

        while q:
            r, c = q.popleft()

            around = [(r-1, c), (r+1, c), (r, c-1), (r, c+1)]

            for nr, nc in around:
                if 0 <= nr < ROW and 0 <= nc < COL and res[nr][nc] == -1:
                    res[nr][nc] = res[r][c] + 1
                    q.append((nr, nc))

        return res