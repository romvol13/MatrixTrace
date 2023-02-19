using MatrixTrace;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void MatrixDimensions()
        {
            // arrange
            int rows = 3;
            int columns = 5;
            int expectedMatrixRows = 3;
            int expectedMatrixColumns = 5;
            Matrix test1 = new Matrix(rows, columns);
            
            // act
            int[,] matrix = test1.Create();
            int actualRows = matrix.GetLength(0);
            int actualColumns = matrix.GetLength(1);

            // assert
            Assert.AreEqual(expectedMatrixRows, actualRows);
            Assert.AreEqual(expectedMatrixColumns, actualColumns);
        }

        [TestMethod]
        public void MatrixValues()
        {
            // arrange
            int rows = 25;
            int columns = 35;
            bool expectedResult = true;
            bool actualResult = true;
            Matrix test2 = new Matrix(rows, columns);

            //act
            int[,] matrix = test2.Create();
            foreach (int value in matrix)
            {
                if (value < 0 | value > 100)
                    actualResult = false;
            }

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }        
    }
}