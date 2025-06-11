namespace _507._Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckPerfectNumber(your_input);
        }

        static private bool CheckPerfectNumber(int num)
        {
            double total = 0;
            int n = 2;
            while (total < num)
            {
                for (int i = (int)(Math.Pow(2, n) - 2); i > 1; i--)
                {
                    if ((int)(Math.Pow(2, n) - 1) % i == 0)   // Crude Prime Check
                    {
                        goto pass;
                    }
                }

                total = Math.Pow(2, n - 1) * (Math.Pow(2, n) - 1);

                pass:
                n++;
            }

            if (total == num)
            {
                return true;
            }
            return false;
        }
    }
}
