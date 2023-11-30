using System;

namespace Galaga
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var matrix = Startup.MasMaker();
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            
            // temp
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }

    public class Startup
    {
        public static string[,] MasMaker()
        {
            string[,] matrix = new String[10, 11];

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i == 0 && j == 0) ||
                        (i == 0 && j == matrix.GetUpperBound(1)) ||
                        (i == matrix.GetUpperBound(0) && j == 0) ||
                        i == matrix.GetUpperBound(0) && j == matrix.GetUpperBound(1))
                        matrix[i, j] = "■";
                    else if (i == 0 || i == matrix.GetUpperBound(0))
                        matrix[i, j] = "═";
                    else if (j == 0 || j == matrix.GetUpperBound(1))
                        matrix[i, j] = "║";
                    else
                        matrix[i, j] = " ";
                }
            }

            return matrix;
        }
    }
}