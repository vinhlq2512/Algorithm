public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int count = guards.Length + walls.Length;
        int[,] grid = new int[m, n];
        // -1 : GUARD
        // -2 : WALL
        foreach (var guard in guards)
        {
            int x = guard[0];
            int y = guard[1];
            grid[x, y] = -1; // Mark guard position
        }

        // Mark walls on the grid
        foreach (var wall in walls)
        {
            int x = wall[0];
            int y = wall[1];
            grid[x, y] = -2; // Mark wall position
        }
        

        // Direction vectors for west, north, east, south
        int[] dx = { 0, -1, 0, 1 }; // Row adjustments
        int[] dy = { -1, 0, 1, 0 }; // Column adjustments
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i, j] == -1)
                {
                    for (int dir = 0; dir < 4; dir++)
                    {
                        int x = i + dx[dir]; 
                        int y = j + dy[dir]; 

                        while (x >= 0 && x < m && y >= 0 && y < n)
                        {
                            if (grid[x, y] == 0)
                            {
                                grid[x, y] = 1;
                                count++;
                            }
                            else if (grid[x, y] == -1 || grid[x, y] == -2) 
                                break;

                            x += dx[dir]; 
                            y += dy[dir];
                        }
                    }
                }
            }
        }
        return m*n - count;
    }
}