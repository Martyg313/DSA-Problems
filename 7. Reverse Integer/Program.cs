namespace _7._Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse(your_input);
        }

        static private int Reverse(int x)
        {
            string reversedWordNum = new string(string.Concat(x).Reverse().ToArray());
            bool negative = false;
            if (x < 0)
            {
                negative = true;
                reversedWordNum = reversedWordNum.Substring(0, reversedWordNum.Length - 1);
            }

            try
            {

                if (!negative)
                {
                    Console.WriteLine(int.Parse(reversedWordNum));
                    return int.Parse(reversedWordNum);
                }

                Console.WriteLine(int.Parse('-' + reversedWordNum));

                return int.Parse('-' + reversedWordNum);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
