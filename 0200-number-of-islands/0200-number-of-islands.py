class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        count = 0

        rows, cols = len(grid), len(grid[0])

        visited = [[False] * cols for _ in range(rows)]

        for r in range(rows):
            for c in range(cols):
                if grid[r][c] == "1" and not visited[r][c]:
                    count += 1
                    dfs(r, c, grid, visited, rows, cols)

        return count


def dfs(r: int, c: int, grid: List[List[str]], visited: List[List[bool]], rows: int, cols: int):
    if r < 0 or r >= rows or c < 0 or c >= cols or grid[r][c] == "0" or visited[r][c]:
        return

    visited[r][c] = True

    dfs(r - 1, c, grid, visited, rows, cols)  # up
    dfs(r + 1, c, grid, visited, rows, cols)  # down
    dfs(r, c - 1, grid, visited, rows, cols)  # left
    dfs(r, c + 1, grid, visited, rows, cols)  # right