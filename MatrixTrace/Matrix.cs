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
        public Matrix(int rows, int columns)
        {
            int[,] matrix = new int[columns, rows];
            Random randNumbers = new Random();
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = randNumbers.Next(0, 101);
                }
            }
            PrintMatrix(matrix);
            TraceCalculation(matrix);
            PrintSpiral(matrix);
        }

        private void TraceCalculation(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.ResetColor();
            Console.WriteLine($"The sum of all elements of the main diagonal is: {sum}");
            Console.WriteLine();
        }

        private void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + "  ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(matrix[i, j] + "  ");
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }

        //Spiral matrix output works only for three row matrix
        private void PrintSpiral(int[,] matrix)
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
