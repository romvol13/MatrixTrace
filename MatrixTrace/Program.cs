﻿using System.Runtime.CompilerServices;

namespace MatrixTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;
            string input;

            //Checking if a first input is an integer and greather than zero 
            Console.Write("Enter the quantity of rows for matrix: ");
            input = Console.ReadLine();
            if (CheckInput(input) == true)
            {
                rows = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            //Checking if a second input is an integer and greather than zero
            Console.WriteLine("Enter the quantity of columns for matrix: ");
            input= Console.ReadLine();
            if (CheckInput(input) == true)
            {
                columns = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Matrix matrix = new Matrix(rows, columns);
            matrix.Print();
            Console.WriteLine($"The sum of all elements on the main diagonal is: {matrix.GetTrace()}");
        }

        private static bool CheckInput(string input)
        {
            int number;
            if (!int.TryParse(input, out number))
            {
                return false;
            }
            else if (number < 1)
            {
                return false;
            }
            return true;
        }
    }
}