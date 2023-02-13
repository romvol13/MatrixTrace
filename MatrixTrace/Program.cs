namespace MatrixTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of columns for matrix:");
            int quantityOfColumns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of rows for matrix:");
            int quantityOfRows = Convert.ToInt32(Console.ReadLine());
            FillTheMatrix(quantityOfColumns, quantityOfRows);
        }

        public static int FillTheMatrix(int rows, int columns)
        {
            return rows * columns;
        }


        //new class 
    }
}