namespace _509._Fibonacci_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fib(your_input);
        }

        static private int Fib(int n)
        {
            return recursiveFib(n);
        }

        static private int recursiveFib(int n)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
            }

            return recursiveFib(n - 1) + recursiveFib(n - 2);
        }
    }
}
