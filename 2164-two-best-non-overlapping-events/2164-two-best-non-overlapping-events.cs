public class Solution {
    public int MaxTwoEvents(int[][] events)
    {
        var times = new List<int[]>();

        foreach (var ev in events)
        {
            times.Add(new int[] { ev[0], 1, ev[2] });
            times.Add(new int[] { ev[1] + 1, 0, ev[2] });
        }

        times.Sort((a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : a[0].CompareTo(b[0]));
        int ans = 0, maxValue = 0;

        foreach (var timeValue in times)
        {
            if (timeValue[1] == 1)
            {
                ans = Math.Max(ans, timeValue[2] + maxValue);
            }
            else
            {
                maxValue = Math.Max(maxValue, timeValue[2]);
            }
        }
        return ans;
    }
}