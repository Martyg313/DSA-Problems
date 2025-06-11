class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        # ~i calculates the index from the end of the list. This could be useful
        temp = ''
        for i in range(len(s) // 2):
            temp = s[i]
            s[i] = s[-i-1]
            s[-i-1] = temp
