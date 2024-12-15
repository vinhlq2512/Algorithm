public class Solution {
    public int[][] ValidArrangement(int[][] pairs)
    {
        var adjacencyMatrix = new Dictionary<int, Queue<int>>();
        var inDegree = new Dictionary<int, int>();
        var outDegree = new Dictionary<int, int>();

        foreach (var pair in pairs)
        {
            int start = pair[0], end = pair[1];

            if (!adjacencyMatrix.ContainsKey(start))
                adjacencyMatrix[start] = new Queue<int>();

            adjacencyMatrix[start].Enqueue(end);
            outDegree[start] = outDegree.GetValueOrDefault(start, 0) + 1;
            inDegree[end] = inDegree.GetValueOrDefault(end, 0) + 1;
        }

        var result = new List<int>();

        int startNode = -1;
        foreach (var node in outDegree.Keys)
        {
            if (outDegree[node] == inDegree.GetValueOrDefault(node, 0) + 1)
            {
                startNode = node;
                break;
            }
        }

        if (startNode == -1)
        {
            startNode = pairs[0][0];
        }

        Visit(startNode, adjacencyMatrix, result);

        result.Reverse();

        int[][] pairedResult = new int[result.Count - 1][];
        for (int i = 1; i < result.Count; i++)
        {
            pairedResult[i - 1] = new int[] { result[i - 1], result[i] };
        }

        return pairedResult;
    }

    private void Visit(int node, Dictionary<int, Queue<int>> adjMatrix, List<int> res)
    {
        if (adjMatrix.TryGetValue(node, out var neighbors))
        {
            while (neighbors.Count > 0)
            {
                int nextNode = neighbors.Dequeue();
                Visit(nextNode, adjMatrix, res);
            }
        }
        res.Add(node);
    }
}