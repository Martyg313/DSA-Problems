class Solution:
    def arrangeCoins(self, n: int) -> int:
        rows = 0
        requirement = 1

        while n - requirement >= 0:
            n -= requirement
            rows += 1
            requirement += 1

        return rows
