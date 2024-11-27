public class Solution {
    private int Bfs(int n, List<List<int>> adjList)
    {
        bool[] visited = new bool[n];
        Queue<int> nodeQueue = new Queue<int>();

        nodeQueue.Enqueue(0);
        visited[0] = true;

        int currentLayerNodeCount = 1;
        int nextLayerNodeCount = 0;
        int layersExplored = 0;

        while (nodeQueue.Count > 0)
        {
            for (int i = 0; i < currentLayerNodeCount; i++)
            {
                int currentNode = nodeQueue.Dequeue();

                if (currentNode == n - 1)
                {
                    return layersExplored; 
                }

                foreach (var neighbor in adjList[currentNode])
                {
                    if (visited[neighbor]) continue;

                    nodeQueue.Enqueue(neighbor); 
                    nextLayerNodeCount++; 
                    visited[neighbor] = true;
                }
            }

            currentLayerNodeCount = nextLayerNodeCount;
            nextLayerNodeCount = 0; 
            layersExplored++;
        }

        return -1; 
    }

    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        List<int> answer = new List<int>();
        List<List<int>> adjList = new List<List<int>>(n);

        for (int i = 0; i < n; i++)
        {
            adjList.Add(new List<int>());
        }

        for (int i = 0; i < n - 1; i++)
        {
            adjList[i].Add(i + 1);
        }

        foreach (var road in queries)
        {
            int u = road[0];
            int v = road[1];
            adjList[u].Add(v); 

            answer.Add(Bfs(n, adjList));
        }

        return answer.ToArray();
    }
}