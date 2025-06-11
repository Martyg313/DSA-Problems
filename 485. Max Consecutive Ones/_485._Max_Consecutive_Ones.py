class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        max_count = 0
        count = 0

        for ele in nums:
            if ele == 1:
                count+=1
            else:
                count = 0
            if count > max_count:
                max_count = count

        return max_count
