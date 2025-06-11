namespace _191._Number_of_1_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HammingWeight(your_input);
        }

        static private int HammingWeight(int n)
        {
            // Returns 1 if the number is a perfect log of base 2
            if (Math.Log2(n) - (int)Math.Log2(n) == 0)
            {
                return 1;
            }

            // If not a perfect log then compute its binary representation
            bool[] binary = new bool[Convert.ToInt32(Math.Ceiling(Math.Log2(n)))];
            for (int i = binary.Length - 1; i > -1; i--)
            {
                if (Math.Pow(2, i) <= n)
                {
                    n -= Convert.ToInt32(Math.Pow(2, i));
                    binary[i] = true;
                }
            }
            return binary.Count(x => x == true);
        }
    }
}
