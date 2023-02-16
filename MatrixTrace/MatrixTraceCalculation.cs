using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTrace
{
    public class MatrixTraceCalculation
    {
        public void CalculationResult()
        {
            int rows;
            int columns;
            Console.WriteLine("Enter the quantity of columns for matrix:");
            bool input1 = int.TryParse(Console.ReadLine(), out columns);
            Console.WriteLine("Enter the quantity of rows for matrix:");
            bool input2 = int.TryParse(Console.ReadLine(), out rows);

            if (IsInputValid(input1, input2) == true)
            {
                FillTheMatrix(rows, columns);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input is invalid!");
            }
            PrintMatrix(FillTheMatrix(rows, columns));
            TraceCalculation(FillTheMatrix(rows, columns));
        }

        private bool IsInputValid(bool input1, bool input2)
        {
            if (input1 & input2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int[,] FillTheMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
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
            Console.WriteLine($"The sum of all elements of the main diagonal is: {sum}");
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
                        Console.Write(matrix[i, j] + "   ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(matrix[i, j] + "   ");
                    }
                }
                Console.WriteLine("  ");
                Console.WriteLine("  ");
            }
        }
    }
}
