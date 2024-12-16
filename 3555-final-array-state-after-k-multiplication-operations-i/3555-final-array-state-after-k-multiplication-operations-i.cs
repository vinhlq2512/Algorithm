public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var maxHeap = new PriorityQueue<(int value, int index), (int priority, int index)>();
        for (int i = 0; i < nums.Length; i++)
        {
            maxHeap.Enqueue((nums[i], i), (nums[i], i));
        }
        for (int i = 0; i < k; i++)
        {
            var (value, index) = maxHeap.Dequeue();
            int newValue = value * multiplier;

            nums[index] = newValue;
            maxHeap.Enqueue((newValue, index), (newValue, index));
        }

        return nums;
    }
}