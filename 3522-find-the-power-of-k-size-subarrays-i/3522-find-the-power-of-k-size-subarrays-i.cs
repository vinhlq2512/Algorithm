public class Solution {
    public int[] ResultsArray(int[] nums, int k)
    {
        int len = nums.Length;
        int[] res = new int[len - k + 1];

        for (int i = 0; i <= len - k; i++)
        {
            int[] subarray = nums.Skip(i).Take(k).ToArray();

            bool isConsecutive = IsConsecutiveAndSorted(subarray);

            res[i] = isConsecutive ? subarray.Max() : -1;
        }


        return res;

        bool IsConsecutiveAndSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}