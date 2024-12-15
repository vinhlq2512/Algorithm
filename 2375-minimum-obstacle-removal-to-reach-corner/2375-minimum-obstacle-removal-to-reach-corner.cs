public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[] { 0, 1 },
        new int[] { 0, -1 },
        new int[] { 1, 0 },
        new int[] { -1, 0 },
    };

    public int MinimumObstacles(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;

        int[,] minObstacles = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                minObstacles[i, j] = int.MaxValue;
            }
        }

        minObstacles[0, 0] = grid[0][0];

        var pq = new PriorityQueue<(int Obstacles, int Row, int Col), int>();

        pq.Enqueue((minObstacles[0, 0], 0, 0), minObstacles[0, 0]);

        while (pq.Count > 0)
        {
            var current = pq.Dequeue();
            int obstacles = current.Obstacles, row = current.Row, col = current.Col;

            if (row == m - 1 && col == n - 1)
            {
                return obstacles;
            }

            foreach (var dir in directions)
            {
                int newRow = row + dir[0], newCol = col + dir[1];

                if (IsValid(grid, newRow, newCol))
                {
                    int newObstacles = obstacles + grid[newRow][newCol];

                    if (newObstacles < minObstacles[newRow, newCol])
                    {
                        minObstacles[newRow, newCol] = newObstacles;
                        pq.Enqueue((newObstacles, newRow, newCol), newObstacles);
                    }
                }
            }
        }

        return minObstacles[m - 1, n - 1];
    }

    private bool IsValid(int[][] grid, int row, int col)
    {
        return row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length;
    }
}