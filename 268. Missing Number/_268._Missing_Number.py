class Solution:
    def missingNumber(self, nums: List[int]) -> int:

        expected = 0
        actual = 0
        for i in range(1, len(nums) + 1):
           expected += i
        for x in nums:
            actual += x

        if expected == actual:
            return 0
        else:
            return expected - actual
