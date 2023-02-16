namespace MatrixTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columns;
            int rows;

            Console.Write("Enter the quantity of columns for matrix: ");
            bool input1 = int.TryParse(Console.ReadLine(), out columns);
            Console.Write("Enter the quantity of rows for matrix: ");
            bool input2 = int.TryParse(Console.ReadLine(), out rows);

            if ((input1 & input2) & (columns > 0 & rows > 0))
            {
                Matrix matrix = new Matrix(columns, rows);
            }
            else
            {
                Console.WriteLine("Input is invalid!");
            }
        }
    }
}