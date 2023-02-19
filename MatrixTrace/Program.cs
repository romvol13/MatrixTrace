namespace MatrixTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;

            //Checking if a first input is an integer and greather than zero 
            Console.Write("Enter the quantity of rows for matrix: ");
            if (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Input is invalid!");
                return;
            }
            else if (rows < 1) 
            {
                Console.WriteLine("Input is invalid!");
                return;
            }

            //Checking if a second input is an integer and greather than zero
            Console.Write("Enter the quantity of columns for matrix: ");
            if (!int.TryParse(Console.ReadLine(), out columns))
            {
                if ((columns < 1))
                Console.WriteLine("Input is invalid!");
                return;
            }
            else if (columns < 1)
            {
                Console.WriteLine("Input is invalid!");
                return;
            }

            Matrix matrix = new Matrix(rows, columns);
            matrix.Print();
            Console.WriteLine(matrix.GetTrace());
        }
    }
}