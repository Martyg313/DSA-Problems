
class Solution:
    def isPalindrome(self, s: str) -> bool:

        palindrome = ''

        for char in s:
            if char.isalnum():
                palindrome += char

        palindrome = palindrome.lower()
        
        for i in range(len(palindrome)//2):
            if palindrome[i] != palindrome[-i-1]:
                return False
        return True
