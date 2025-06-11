class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:

        # Base cases for length 1 and 2
        if len(s) == 0:
            return 0
        elif len(s) == 1:
            return 1

        # Case for when len(s) > 1
        hash_set = set()
        length = 1

        for i in range(len(s)):
            for j in range(i,len(s)):
                if not hash_set.__contains__(s[j]):
                    hash_set.update(s[j])
                else:
                    break
            if len(hash_set) > length:
                length = len(hash_set)
            hash_set = set()

        return length
