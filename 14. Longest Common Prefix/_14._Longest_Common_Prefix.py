class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:

        length = len(strs)
        min = len(strs[0])
        min_word = strs[0]

        # finds minimum length string in strs
        for i in range(length):
            if len(strs[i]) < min:
                min = len(strs[i])
                min_word = strs[i]

        j = 0
        count = 0
        prefix = ''

        # Checks for each letter across words
        for x in range(min):
            for i in range(length):
                if strs[i][j] == min_word[x]:
                    count += 1
            if count == length:
                prefix += strs[i][j]
            else:
                return prefix
            count = 0
            j += 1

        return prefix
