class Solution:
    def uniqueOccurrences(self, arr: List[int]) -> bool:
        # B1: Đếm tần suất
        map_num = defaultdict(int)
        for num in arr:
            map_num[num] += 1  

        occurrences = set()
        for freq in map_num.values():
            if freq in occurrences:
                return False
            occurrences.add(freq)

        return True