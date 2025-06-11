namespace _941._Valid_Mountain_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValidMountainArray(your_input);
        }

        static private bool ValidMountainArray(int[] arr)
        {
            if (arr.Length <= 2 || arr[1] <= arr[0] || arr[arr.Length - 1] >= arr[arr.Length - 2])
            {
                return false;
            }

            bool increase = true;

            for (int i = 2; i < arr.Length; i++)
            {
                if (increase)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        increase = false;
                    }
                    else if (arr[i] == arr[i - 1])
                    {
                        return false;
                    }
                }
                else
                {
                    if (arr[i] >= arr[i - 1])
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
