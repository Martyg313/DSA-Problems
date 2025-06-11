namespace _258._Add_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddDigits(your_input);
        }

        static private int AddDigits(int num)
        {
            string wordNum = num.ToString();
            while (num >= 10)
            {
                num = 0;
                foreach (char item in wordNum)
                {
                    num += Convert.ToInt32(char.GetNumericValue(item));
                }
                wordNum = num.ToString();
            }
            return num;
        }
    }
}
