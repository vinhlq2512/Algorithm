public class Solution {
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        var adjList = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adjList[i] = new List<int>();
        }
        foreach (var edge in edges)
        {
            int node1 = edge[0];
            int node2 = edge[1];
            adjList[node1].Add(node2);
            adjList[node2].Add(node1);
        }

        int componentCount = 0;

        Dfs(0, -1, adjList, values, k, ref componentCount);

        return componentCount;
    }

    private int Dfs(
        int currentNode,
        int parentNode,
        List<int>[] adjList,
        int[] nodeValues,
        int k,
        ref int componentCount
    )
    {
        int sum = 0;

        foreach (var neighborNode in adjList[currentNode])
        {
            if (neighborNode != parentNode)
            {
                sum += Dfs(neighborNode, currentNode, adjList, nodeValues, k, ref componentCount);
                sum %= k; 
            }
        }

        sum += nodeValues[currentNode];
        sum %= k;

        if (sum == 0)
        {
            componentCount++;
        }

        return sum;
    }
}