class Solution:
    def minimumDiameterAfterMerge(self, edges1: List[List[int]], edges2: List[List[int]]) -> int:
        n = len(edges1) + 1
        m = len(edges2) + 1
        
        
        dict1 = defaultdict(list)
        for edge in edges1:
            dict1[edge[0]].append(edge[1])
            dict1[edge[1]].append(edge[0])
            
        dict2 = defaultdict(list)
        for edge in edges2:
            dict2[edge[0]].append(edge[1])
            dict2[edge[1]].append(edge[0])
            
        def getDiameter(dict):
            def dfs(node, parent, depth):
                maxDepth = depth
                maxNode = node
                for child in dict[node]:
                    if child == parent:
                        continue
                    childNode, childDepth = dfs(child, node, depth + 1)
                    if childDepth > maxDepth:
                        maxDepth = childDepth
                        maxNode = childNode
                return maxNode, maxDepth
            
            node1, _ = dfs(0, -1, 0)
            node2, diameter = dfs(node1, -1, 0)
            return diameter
            
        d1 = getDiameter(dict1)
        d2 = getDiameter(dict2)
        
        
        return max(d1, d2, ceil(d1 / 2) + ceil(d2 / 2) + 1)