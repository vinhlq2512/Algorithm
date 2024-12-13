public class Solution {
    public long FindScore(int[] nums)
    {
        long score = 0;
        int n = nums.Length;
        PriorityQueue<(int value, int index), (int value, int index)> queue = new PriorityQueue<(int value, int index), (int value, int index)>();

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue((nums[i], i), (nums[i], i));
        }

        bool[] marked = new bool[n + 2];

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            int i = item.index + 1;
            if (!marked[i])
            {
                score += item.value;
                marked[i + 1] = true;
                marked[i - 1] = true;
            }
        }
        return score;
    }
}