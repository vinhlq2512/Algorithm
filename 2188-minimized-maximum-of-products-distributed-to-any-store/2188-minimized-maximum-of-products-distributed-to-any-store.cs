public class Solution {
    public int MinimizedMaximum(int n, int[] quantities)
    {
        int low = 1, high = quantities.Length > 0 ? quantities.Max(): 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (CanDistribute(mid))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1; 
            }
        }
        
        return low;

        bool CanDistribute(int x)
        {
            var storesNeeded = 0;
            foreach (var quantity in quantities)
            {
                storesNeeded += (int)Math.Ceiling((double)quantity / x);
                if (storesNeeded > n) return false; 
            }
            return storesNeeded <= n;
        }
    }
}