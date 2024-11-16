public class Solution {
        public int[] ResultsArray(int[] nums, int k)
 {
     int len = nums.Length;
     int[] res = new int[len - k + 1];
     if (k == 1)
     {
         return nums;
     }

     if (k >= len)
     {
         res[0] = nums.Max();
         return res;
     }


     int q = 0;
     for (int i = 0; i < len; i++)
     {
         for (int j = 0; j < k - 1; j++)
         {
             if (nums[i + j] >= nums[i + j + 1] || nums[i + j] - nums[i + j + 1] < -1)
             {
                 res[q] = -1;
                 break;
             }

             if (j == k - 2)
             {
                 res[q] = nums[i + j + 1];
             }


         }
         q++;
         if (q >= len - k + 1)
         {
             break;
         }
     }
     return res;
 }

}