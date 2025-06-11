class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """

        curr = 0
        for i in range(len(nums)):
            if curr == i and nums[i] != 0: # no swapping
               curr += 1
            elif curr != i and nums[i] != 0: # with swapping
                nums[curr] = nums[i]
                nums[i] = 0
                curr += 1
