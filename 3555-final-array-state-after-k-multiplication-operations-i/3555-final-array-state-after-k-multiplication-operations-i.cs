public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var maxHeap = new PriorityQueue<(int value, int index), (int priority, int index)>();
        for (int i = 0; i < nums.Length; i++)
        {
            maxHeap.Enqueue((nums[i], i), (nums[i], i));
        }
        int j = 0;
        while (j < k)
        {
            var heap = maxHeap.Dequeue();
            int newValue = heap.value * multiplier;
            int index = heap.index;
            nums[index] = newValue;
            maxHeap.Enqueue((newValue, index), (newValue, index));
            j++;
        }

        return nums;
    }
}