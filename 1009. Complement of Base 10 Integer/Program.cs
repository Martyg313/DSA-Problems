namespace _1009._Complement_of_Base_10_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BitwiseComplement(your_input);
        }

        private static int BitwiseComplement(int n)
        {

            List<byte> values = new List<byte>();
            if (n == 0)
            {
                return 1;
            }

            while (n != 1)
            {
                n = Math.DivRem(n, 2, out int remainder);
                if (remainder == 0)
                {
                    values.Add(1);
                }
                else
                {
                    values.Add(0);
                }
            }
            values.Add(0);
            int complement = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == 1)
                {
                    complement += Convert.ToInt32(Math.Pow(2, i));
                }
            }

            return complement;
        }
    }
}
