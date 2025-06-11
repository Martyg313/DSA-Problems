namespace _66._Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlusOne(your_input);
        }

        static private int counts = 1;
        static private int[] PlusOne(int[] digits)
        {
            return carryOne(digits);
        }

        static private int[] carryOne(int[] digits)
        {
            Console.WriteLine(counts);
            if (counts == digits.Length + 1)
            {
                int[] newDigits = new int[counts];
                newDigits[0] = 1;
                return newDigits;
            }
            if (digits[digits.Length - counts] + 1 == 10)
            {

                digits[digits.Length - counts] = 0;
                counts++;
                return carryOne(digits);
            }
            else
            {
                digits[digits.Length - counts]++;
                return digits;
            }
        }
    }
}
