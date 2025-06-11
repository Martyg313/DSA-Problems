class Solution:
    def convertToBase7(self, num: int) -> str:
        numm = abs(num)
        base_seven = ''

        # Corner case for zero
        if numm == 0:
            return '0'

        # Finds the remainders for base_seven
        while abs(numm) > 0:
            remainder = numm
            numm = numm // 7
            remainder -= (numm * 7)
            base_seven = str(remainder) + base_seven

        # If the number is below zero, then attach a negative
        if num < 0:
            base_seven = '-' + base_seven
            
        return base_seven
