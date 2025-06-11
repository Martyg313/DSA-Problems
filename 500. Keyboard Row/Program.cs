namespace _500._Keyboard_Row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindWords(your_input);
        }

        static private string[] FindWords(string[] words)
        {
            string first = "qwertyuiopQWERTYUIOP", second = "asdfghjklASDFGHJKL", third = "zxcvbnmZXCVBNM";
            string targetRow;
            string[] output = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);

                if (first.Contains(words[i][0]))
                {
                    targetRow = first;
                }
                else if (second.Contains(words[i][0]))
                {
                    targetRow = second;
                }
                else
                {
                    targetRow = third;
                }

                for (int k = 1; k < words[i].Length; k++)
                {
                    if (!targetRow.Contains(words[i][k]))
                    {
                        goto start;  // eliminate since cant be on same row                     
                    }
                }
                output[i] = words[i];
            start:;
            }

            return output.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }
    }
}
