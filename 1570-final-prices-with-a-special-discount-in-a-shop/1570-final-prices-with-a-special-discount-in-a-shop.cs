public class Solution {
    public int[] FinalPrices(int[] prices)
    {
        int n = prices.Length;
        int[] res = (int[])prices.Clone();

        Stack<(int, int)> stack = new Stack<(int, int)>();
        for (int i = n - 1; i >= 0; i--)
        {
            stack.Push((prices[i], i));
        }
        while (stack.Count > 0)
        {
            (int value, int index) = stack.Pop();
            for (int j = index + 1; j < n; j++)
            {
                if (value >= prices[j])
                {
                    res[index] = value - prices[j];
                    break;
                }
            }

        }
        return res;
    }
}