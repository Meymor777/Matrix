namespace Matrix
{
    using Matrix.BL;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter size matrix [line, colum] and press ENTER.  (ESC to exit):");
                Console.Write("[");

                var lineStr = ReadLineWithCancel();
                if (Int32.TryParse(lineStr, out var line) && line > 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    break;
                }
                var columStr = ReadLineWithCancel();
                if (Int32.TryParse(columStr, out var colum) && colum > 0)
                {
                    Console.WriteLine("]");
                }
                else
                {
                    break;
                }

                var matrix = new Matrix(line, colum);
                Console.WriteLine();
                MatrixInConsole.PaintMatrix(matrix);
                Console.WriteLine();
                MatrixInConsole.PaintMatrixTraceWithSumElements(matrix);
                Console.WriteLine();
                MatrixInConsole.PaintElementsLikeSnailShell(matrix);
                Console.WriteLine();
            }
        }

        private static string ReadLineWithCancel()
        {
            string result = null;
            var buffer = new StringBuilder();

            var info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Escape)
            {
                if (info.Key == ConsoleKey.Backspace)
                {
                    if (buffer.Length > 0)
                    {
                        buffer.Remove(buffer.Length - 1, 1);
                        Console.CursorLeft--;
                        Console.Write(" ");
                        Console.CursorLeft--;
                    }
                }
                else if (info.Key == ConsoleKey.Enter && buffer.Length != 0)
                {
                    result = buffer.ToString();
                    break;
                }
                else if (Int32.TryParse(new string(info.KeyChar, 1), out var count) && count >= 0)
                {
                    if (count > 0 || (buffer.Length > 0 && count == 0))
                    {
                        Console.Write(info.KeyChar);
                        buffer.Append(info.KeyChar);
                    }
                }
                info = Console.ReadKey(true);
            }

            return result;
        }
    }
}
