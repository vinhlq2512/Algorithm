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

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            if (nums[item.index] != 0)
            {
                score += item.value;
                if (item.index - 1 >= 0)
                {
                    nums[item.index - 1] = 0;
                }
                if (item.index + 1 <= n - 1)
                {
                    nums[item.index + 1] = 0;
                }
            }

        }
        return score;
    }
}