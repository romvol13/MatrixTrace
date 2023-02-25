using MatrixTrace;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

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
            int[,] matrix = test1.ReturnMatrix();
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
            int[,] matrix = test2.ReturnMatrix();
            foreach (int value in matrix)
            {
                if (value < 0 | value > 100)
                    actualResult = false;
            }

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InputValues1()  //Both input values are negative
        {
            // arrange
            int rows = -1;
            int columns = -7;
            Matrix test3 = new Matrix(rows, columns);

            //act
            bool actualResult = test3.CheckValues(rows, columns);

            // assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void InputValues2()  //One input value is greather than zero, another is negative
        {
            // arrange
            int rows = 5;
            int columns = 0;
            Matrix test4 = new Matrix(rows, columns);

            //act
            bool actualResult = test4.CheckValues(rows, columns);

            // assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void InputValues3()     //One of the input values is zero
        {
            // arrange
            int rows = 0;
            int columns = 22;
            Matrix test5 = new Matrix(rows, columns);

            //act
            bool actualResult = test5.CheckValues(rows, columns);

            // assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void TraceCalculationCheck()     //One of the input values is zero
        {
            // arrange
            int rows = 5;
            int columns = 5;
            int expectedResult = 0;
            Matrix test6 = new Matrix(rows, columns);

            //act
            int[,] matrix = test6.ReturnMatrix();
            for (int i = 0; i < Math.Min(rows, columns); i++)
            {
                expectedResult += matrix[i, i];
            }
            int actualResult = test6.GetTrace();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}