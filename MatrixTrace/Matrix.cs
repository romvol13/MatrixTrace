using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTrace
{
    public class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _columns;

        public Matrix(int rows, int columns)
        {
            if (CheckValues(rows, columns) == false)
            {
                throw new ArgumentException("Invalid input");
            }

            _rows = rows;
            _columns = columns;
            _matrix = new int[_rows, _columns];
            Create();
        }

        public int GetTrace()
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(_rows, _columns); i++)
            {
                sum += _matrix[i, i];
            }
            return sum;
        }

        public void Print()
        {
            string value = string.Empty;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        value = _matrix[i,j].ToString();
                        Console.Write(value.PadLeft(4));
                    }
                    else
                    {
                        Console.ResetColor();
                        value = _matrix[i,j].ToString();
                        Console.Write(value.PadLeft(4));
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        public int[,] ReturnMatrixClone()   //method for unit test
        {
            int[,] clonedMatrix = (int[,])_matrix.Clone();
            return clonedMatrix;
        }

        public bool CheckValues(int rows, int columns)
        {
            if (rows < 1 | columns < 1)
            {
                return false;
            }
            return true;
        }

        private void Create()
        {
            Random randNumbers = new Random();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrix[i, j] = randNumbers.Next(0, 101);
                }
            }
        }

        //Spiral matrix output works only for three row matrix
        public void PrintSpiral()
        {
            Console.ResetColor();
            Console.WriteLine("Output from matrix in spiral order:");
            for (int i = 0, j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write(_matrix[i, j]);
                Console.Write(" ");
            }

            for (int i = 1, j = _matrix.GetLength(1) - 1; i < _matrix.GetLength(0); i++)
            {
                Console.Write(_matrix[i, j]);
                Console.Write(" ");
            }

            for (int i = _matrix.GetLength(0) - 1, j = _matrix.GetLength(1) - 2; j > -1; j--)
            {
                Console.Write(_matrix[i, j]);
                Console.Write(" ");
            }

            for (int i = 1, j = 0; j < _matrix.GetLength(1) - 1; j++)
            {
                Console.Write(_matrix[i, j]);
                Console.Write(" ");
            }
            Console.Read();
        }
    }
}
