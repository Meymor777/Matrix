using System.Text;

namespace Matrix.BL
{
    public static class MatrixInConsole
    {
        public static void PaintMatrix(Matrix matrix)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.Lines; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write("[ ");

                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j].ToString().PadLeft(3));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(matrix[i, j].ToString().PadLeft(3));
                    }

                    Console.Write(" ");
                }
                Console.Write("]");
            }
            Console.WriteLine();
        }

        public static void PaintMatrixTraceWithSumElements(Matrix matrix)
        {
            Console.WriteLine("Matrix trace:");
            var minLength = Math.Min(matrix.Lines, matrix.Columns);
            var result = new StringBuilder();
            for (int i = 0; i < minLength; i++)
            {
                if (i != 0)
                {
                    result.Append(" + ");
                }
                result.Append(matrix[i, i]);
            }
            result.Append(" = ");
            result.Append(matrix.FindMatrixTrace());
            Console.WriteLine(result.ToString());
        }

        public static void PaintElementsLikeSnailShell(Matrix matrix)
        {
            Console.WriteLine("Elements going like snail shells:");

            var ind = 1;
            var elements = matrix.GetElementsLikeSnailShell();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i].ToString().PadLeft(3));
                if (i != elements.Length - 1)
                {
                    Console.Write("->");
                }

                if (ind % 10 == 0)
                {
                    Console.WriteLine();
                }
                ind++;
            }
            Console.WriteLine();
        }
    }
}
