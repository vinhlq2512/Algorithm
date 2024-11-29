public class Solution {
    public int MinimumTime(int[][] grid)
    {
        if (grid[0][1] > 1 && grid[1][0] > 1)
        {
            return -1;
        }

        int rows = grid.Length, cols = grid[0].Length;
        int[][] directions = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };
        bool[,] visited = new bool[rows, cols];

        var pq = new PriorityQueue<(int time, int row, int col), int>();
        pq.Enqueue((grid[0][0], 0, 0), grid[0][0]);

        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            int time = curr.time, row = curr.row, col = curr.col;

            if (row == rows - 1 && col == cols - 1)
            {
                return time;
            }

            if (visited[row, col])
            {
                continue;
            }
            visited[row, col] = true;

            foreach (var d in directions)
            {
                int nextRow = row + d[0], nextCol = col + d[1];
                if (!IsValid(visited, nextRow, nextCol))
                {
                    continue;
                }

                int waitTime = ((grid[nextRow][nextCol] - time) % 2 == 0) ? 1 : 0;
                int nextTime = Math.Max(grid[nextRow][nextCol] + waitTime, time + 1);
                pq.Enqueue((nextTime, nextRow, nextCol), nextTime);
            }
        }
        return -1;
    }

    private bool IsValid(bool[,] visited, int row, int col)
    {
        return row >= 0 && col >= 0 &&
               row < visited.GetLength(0) &&
               col < visited.GetLength(1) &&
               !visited[row, col];
    }
}