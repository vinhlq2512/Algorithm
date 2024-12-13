public class Solution {
    public long FindScore(int[] nums)
    {
        long score = 0;
        int n = nums.Length;
        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[2];
            arr[i][0] = nums[i];
            arr[i][1] = i;
        }

        Array.Sort(arr, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 0; i < arr.Length; i++)
        {
            int value = arr[i][0];
            int index = arr[i][1];

            if (nums[index] != 0)
            {
                score += value;
                if (index - 1 >= 0)
                {
                    nums[index - 1] = 0;
                }
                if (index + 1 <= n - 1)
                {
                    nums[index + 1] = 0;
                }
            }
        }


        return score;
    }
}