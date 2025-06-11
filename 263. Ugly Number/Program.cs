namespace _263._Ugly_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsUgly(your_input);
        }

        static private bool IsUgly(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            int[] allFactors = factorsOfN(n);
            for (int i = 0; i < allFactors.Length; i++)
            {

                if (Prime(allFactors[i]))
                {
                    if (allFactors[i] != 2 && allFactors[i] != 3 && allFactors[i] != 5)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static private int[] factorsOfN(int n)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i == (n / i))
                    {
                        factors.Add(i);
                    }
                    else
                    {
                        factors.Add(i);
                        factors.Add(n / i);
                    }
                }
            }
            return factors.ToArray();
        }

        static private bool Prime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            for (int i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
