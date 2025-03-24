class Solution:
    def countDays(self, days: int, meetings: list[list[int]]) -> int:
        free_days = days
        prev_end = 0

        meetings.sort()

        for start, end in meetings:
            start = max(start, prev_end + 1)
            length = end - start + 1
            free_days -= max(length, 0)
            prev_end = max(prev_end, end)

        return free_days