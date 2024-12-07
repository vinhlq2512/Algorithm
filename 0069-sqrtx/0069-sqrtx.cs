public class Solution {
    public int MySqrt(int x)
    {
        if (x == 0 || x == 1)
            return x;
        int start = 0;
        int end = x;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            
            if ((long)mid * mid == x)
            {
                return mid;
            }
            
            if ((long)mid * mid > x)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        return end;
    }

}