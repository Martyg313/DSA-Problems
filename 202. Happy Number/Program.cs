namespace _202._Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsHappy(your_input);
        }

        // keeps track of repeated values
        private static Dictionary<int, int> values = new Dictionary<int, int> { };

        private static bool IsHappy(int n)
        {
            string wordNumber = n.ToString();
            int sum = 0;
            for (int i = 0; i < wordNumber.Length; i++)  // Sum of square of digits --> sum
            {
                sum += Convert.ToInt32(char.GetNumericValue(wordNumber[i]) * char.GetNumericValue(wordNumber[i]));
            }
            if (sum == 1)
            {
                values.Clear();
                return true;
            }
            else if (values.ContainsKey(n)) // If value is repeated then must be false
            {
                values.Clear();
                return false;
            }
            values.Add(n, sum);
            return IsHappy(sum);
        }
    }
}
