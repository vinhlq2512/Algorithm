public class Solution {
    public int FindChampion(int n, int[][] edges)
    {
        int[] indegree = new int[n];

        foreach (var edge in edges)
        {
            indegree[edge[1]]++;
        }

        int champ = -1;
        int champCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (indegree[i] == 0)
            {
                champCount++;
                champ = i;
            }
        }

        return champCount > 1 ? -1 : champ;
    }
}