using Matrix.Types;
using System.Text;

namespace Matrix.BL
{
    public class Matrix
    {
        private int[,] _matrixData;
        public readonly int Lines;
        public readonly int Columns;

        public Matrix(int lines, int columns)
        {
            if (lines <= 0 || columns <= 0)
            {
                throw new InvalidParameterException("The size of the line and column matrix must be greater than 0");
            }
            _matrixData = new int[lines, columns];
            var random = new Random();
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _matrixData[i, j] = random.Next(0, 101);
                }
            }
            Lines = lines;
            Columns = columns;
        }

        public Matrix(int[,] matrixData)
        {
            if (matrixData == null)
            {
                throw new InvalidParameterException("The size of the line and column matrix must be greater than 0");
            }
            else if (matrixData.GetLength(0) <= 0 || matrixData.GetLength(1) <= 0)
            {
                throw new InvalidParameterException("The size of the line and column matrix must be greater than 0");
            }

            _matrixData = (int[,])matrixData.Clone();
            Lines = matrixData.GetLength(0);
            Columns = matrixData.GetLength(1);
        }



        public int FindMatrixTrace()
        {
            var minLength = Math.Min(Lines, Columns);
            var result = 0;
            for (int i = 0; i < minLength; i++)
            {
                result += _matrixData[i, i];
            }
            return result;
        }

        public int[] GetElementsLikeSnailShell()
        {
            var result = new List<int>();
            var minLine = 0;
            var maxLine = Lines - 1;
            var minColumm = 0;
            var maxColumm = Columns - 1;

            while (true)
            {
                for (int i = minColumm; i <= maxColumm; i++)
                {
                    result.Add(_matrixData[minLine, i]);
                }
                minLine++;
                if (minLine > maxLine)
                {
                    break;
                }

                for (int i = minLine; i <= maxLine; i++)
                {
                    result.Add(_matrixData[i, maxColumm]);
                }
                maxColumm--;
                if (minColumm > maxColumm)
                {
                    break;
                }

                for (int i = maxColumm; i >= minColumm; i--)
                {
                    result.Add(_matrixData[maxLine, i]);
                }
                maxLine--;
                if (minLine > maxLine)
                {
                    break;
                }

                for (int i = maxLine; i >= minLine; i--)
                {
                    result.Add(_matrixData[i, minColumm]);
                }
                minColumm++;
                if (minColumm > maxColumm)
                {
                    break;
                }
            }
            return result.ToArray();
        }



        public int this[int line, int column]
        {
            get => GetValue(line, column);
            set => SetValue(line, column, value);
        }
        public int GetValue(int line, int column)
        {
            if (line < 0 || line >= Lines || column < 0 || column >= Columns)
            {
                throw new InvalidParameterException("The program has exceeded the specified matrix size");
            }
            return _matrixData[line, column];
        }
        public void SetValue(int line, int column, int value)
        {
            if (line < 0 || line >= Lines || column < 0 || column >= Columns)
            {
                throw new InvalidParameterException("The program has exceeded the specified matrix size");
            }
            _matrixData[line, column] = value;
        }



        public override string? ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < Lines; i++)
            {
                if (i != 0)
                {
                    result.Append("\n");
                }
                result.Append("[ ");

                for (int j = 0; j < Columns; j++)
                {
                    result.Append(_matrixData[i, j].ToString().PadLeft(3));
                    result.Append(" ");
                }
                result.Append("]");
            }

            return result.ToString();
        }
    }
}

