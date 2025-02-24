class Solution:
    def __init__(self):
        self.bob_path = {}
        self.visited = []
        self.tree = []
        self.max_income = float("-inf")

    def mostProfitablePath(self, edges, bob, amount):
        n = len(amount)
        self.tree = [[] for _ in range(n)]
        self.bob_path = {}
        self.visited = [False] * n

        for edge in edges:
            self.tree[edge[0]].append(edge[1])
            self.tree[edge[1]].append(edge[0])

        self.find_bob_path(bob, 0)

        self.visited = [False] * n
        self.find_alice_path(0, 0, 0, amount)

        return self.max_income

    def find_bob_path(self, source_node, time):
        self.bob_path[source_node] = time
        self.visited[source_node] = True

        # Destination for Bob is found
        if source_node == 0:
            return True

        for adjacent_node in self.tree[source_node]:
            if not self.visited[adjacent_node] and self.find_bob_path(
                adjacent_node, time + 1
            ):
                return True

        self.bob_path.pop(source_node, None)
        return False

    def find_alice_path(self, source_node, time, income, amount):
        self.visited[source_node] = True

        if (
            source_node not in self.bob_path
            or time < self.bob_path[source_node]
        ):
            income += amount[source_node]
        elif time == self.bob_path[source_node]:
            income += amount[source_node] // 2

        if len(self.tree[source_node]) == 1 and source_node != 0:
            self.max_income = max(self.max_income, income)

        for adjacent_node in self.tree[source_node]:
            if not self.visited[adjacent_node]:
                self.find_alice_path(adjacent_node, time + 1, income, amount)