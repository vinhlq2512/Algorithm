public class Solution {
     public int FindLengthOfShortestSubarray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        int len = arr.Length;

        while (left < len - 1 && arr[left + 1] >= arr[left])
        {
            left++;
        }
        if (left == len - 1)
        {
            return 0;
        }

        while (right > 0 && arr[right] >= arr[right - 1])
        {
            right--;
        }

        // space will delete
        int minRemovals = Math.Min(len - left - 1, right);

        int i = 0, j = right;
        while (i <= left && j < len)
        {
            // if array left smaller than => increase left
            if (arr[i] <= arr[j])
            {
                minRemovals = Math.Min(minRemovals, j - i - 1);
                i++;
            }
            // if array right greater than => increase right
            else
            {
                j++;
            }
        }

        return minRemovals;

    }
}