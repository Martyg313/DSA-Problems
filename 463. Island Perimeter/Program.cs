namespace _463._Island_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IslandPerimeter(your_input);
        }

        static private int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i - 1 < 0) // above
                        {
                            perimeter++;
                        }
                        else
                        {
                            if (grid[i - 1][j] == 0)
                            {
                                perimeter++;
                            }
                        }

                        if (i + 1 > grid.Length - 1) // below
                        {
                            perimeter++;
                        }
                        else
                        {
                            if (grid[i + 1][j] == 0)
                            {
                                perimeter++;
                            }
                        }

                        if (j - 1 < 0) // left
                        {
                            perimeter++;
                        }
                        else
                        {
                            if (grid[i][j - 1] == 0)
                            {
                                perimeter++;
                            }
                        }

                        if (j + 1 > grid[0].Length - 1) // right
                        {
                            perimeter++;
                        }
                        else
                        {
                            if (grid[i][j + 1] == 0)
                            {
                                perimeter++;
                            }
                        }
                    }
                }
            }

            return perimeter;
        }
    }
}
