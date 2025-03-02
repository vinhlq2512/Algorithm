class Solution:
    def mergeArrays(self, nums1: List[List[int]], nums2: List[List[int]]) -> List[List[int]]:
        hash_map = {}

        for num in nums1:
            id1, val1 = num
            hash_map[id1] = hash_map.get(id1, 0) + val1

        for num in nums2:
            id2, val2 = num
            hash_map[id2] = hash_map.get(id2, 0) + val2

        res = sorted([[k, v] for k, v in hash_map.items()])

        return res