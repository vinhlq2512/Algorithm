public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new[] { 1, 3 },
        new[] { 0, 2, 4 },
        new[] { 1, 5 },
        new[] { 0, 4 },
        new[] { 3, 5, 1 },
        new[] { 4, 2 }
    };

    public int SlidingPuzzle(int[][] board)
    {
        var startState = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                startState.Append(board[i][j]);
            }
        }

        var visited = new Dictionary<string, int>();

        Dfs(startState.ToString(), visited, startState.ToString().IndexOf('0'), 0);

        return visited.TryGetValue("123450", out int moves) ? moves : -1;
    }

    private void Dfs(string state, Dictionary<string, int> visited, int zeroPos, int moves)
    {
        if (visited.ContainsKey(state) && visited[state] <= moves)
        {
            return;
        }
        visited[state] = moves;

        foreach (int nextPos in directions[zeroPos])
        {
            string newState = Swap(state, zeroPos, nextPos); 
            Dfs(newState, visited, nextPos, moves + 1); 
        }
    }

    private string Swap(string str, int i, int j)
    {
        var sb = new StringBuilder(str);
        char temp = sb[i];
        sb[i] = sb[j];
        sb[j] = temp;
        return sb.ToString();
    }
}