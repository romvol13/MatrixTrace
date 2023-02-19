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
        public int[,] matrix;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
            Create();
        }

        public int[,] Create()
        {
            Random randNumbers = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = randNumbers.Next(0, 101);
                }
            }
            return matrix;
        }

        public int GetTrace()
        {
            int sum = 0;
            for (int i = 0, j = 0; i < Math.Min(rows, columns); i++, j++)
            {
                 if (j == i)
                 {
                    sum += matrix[i, j];
                 }
            }
            return sum;
        }

        public void Print()
        {
            string value = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        value = matrix[i,j].ToString();
                        Console.Write(value.PadLeft(4));
                    }
                    else
                    {
                        Console.ResetColor();
                        value = matrix[i,j].ToString();
                        Console.Write(value.PadLeft(4));
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        //Spiral matrix output works only for three row matrix
        public void PrintSpiral()
        {
            Console.ResetColor();
            Console.WriteLine("Output from matrix in spiral order:");
            for (int i = 0, j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]);
                Console.Write(" ");
            }

            for (int i = 1, j = matrix.GetLength(1) -1; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            
            for (int i = matrix.GetLength(0)-1, j = matrix.GetLength(1) - 2; j > -1; j--)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }

            for (int i = 1, j = 0; j < matrix.GetLength(1)-1; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.Read();
        }
    }
}
