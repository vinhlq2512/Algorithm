class Solution:
    def mincostTickets(self, days: List[int], costs: List[int]) -> int:
        travel_days = set(days)
        last_day = days[-1]
        dp = [0] * (last_day + 1)
        
        for d in range(1, last_day + 1):
            if d not in travel_days:
                dp[d] = dp[d - 1]
            else:
                cost_with_1_day_pass = dp[d - 1] + costs[0]
                cost_with_7_day_pass = dp[max(0, d - 7)] + costs[1]
                cost_with_30_day_pass = dp[max(0, d - 30)] + costs[2]
                dp[d] = min(cost_with_1_day_pass, cost_with_7_day_pass, cost_with_30_day_pass)
        
        return dp[last_day]