using DataStructure;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTest
{
    [TestFixture]
    public class MatrixHelperTest
    {
        [Test]
        public void RotateMatrix90Degree()
        {
            var inputMatrix = GetSampleMatrix();

            int[,] expectedMatrix = new int[4, 3];
            expectedMatrix[0, 0] = 4;
            expectedMatrix[0, 1] = 8;
            expectedMatrix[0, 2] = 12;

            expectedMatrix[1, 0] = 3;
            expectedMatrix[1, 1] = 7;
            expectedMatrix[1, 2] = 11;

            expectedMatrix[2, 0] = 2;
            expectedMatrix[2, 1] = 6;
            expectedMatrix[2, 2] = 10;

            expectedMatrix[3, 0] = 1;
            expectedMatrix[3, 1] = 5;
            expectedMatrix[3, 2] = 9;


            var result = MatrixHelper.RotateMatrix(inputMatrix, Rotate.Angle90);
            Assert.AreEqual(expectedMatrix, result);

        }

        [Test]
        public void RotateMatrix180Degree()
        {
            var inputMatrix = GetSampleMatrix();

            int[,] expectedMatrix = new int[3, 4];
            expectedMatrix[0, 0] = 12;
            expectedMatrix[0, 1] = 11;
            expectedMatrix[0, 2] = 10;
            expectedMatrix[0, 3] = 9;

            expectedMatrix[1, 0] = 8;
            expectedMatrix[1, 1] = 7;
            expectedMatrix[1, 2] = 6;
            expectedMatrix[1, 3] = 5;

            expectedMatrix[2, 0] = 4;
            expectedMatrix[2, 1] = 3;
            expectedMatrix[2, 2] = 2;
            expectedMatrix[2, 3] = 1;

            var result = MatrixHelper.RotateMatrix(inputMatrix, Rotate.Angle180);
            Assert.AreEqual(expectedMatrix, result);

        }

        [Test]
        public void RotateMatrix270Degree()
        {
            var inputMatrix = GetSampleMatrix();

            int[,] expectedMatrix = new int[4, 3];
            expectedMatrix[0, 0] = 9;
            expectedMatrix[0, 1] = 5;
            expectedMatrix[0, 2] = 1;

            expectedMatrix[1, 0] = 10;
            expectedMatrix[1, 1] = 6;
            expectedMatrix[1, 2] = 2;

            expectedMatrix[2, 0] = 11;
            expectedMatrix[2, 1] = 7;
            expectedMatrix[2, 2] = 3;

            expectedMatrix[3, 0] = 12;
            expectedMatrix[3, 1] = 8;
            expectedMatrix[3, 2] = 4;


            var result = MatrixHelper.RotateMatrix(inputMatrix, Rotate.Angle270);
            Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void RotateMatrix0Degree()
        {
            var inputMatrix = GetSampleMatrix();

            int[,] expectedMatrix = inputMatrix;

            var result = MatrixHelper.RotateMatrix(inputMatrix, Rotate.Angle0);
            Assert.AreEqual(expectedMatrix, result);
        }


        private int[,] GetSampleMatrix()
        {
            int[,] matrix = new int[3, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;

            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 7;
            matrix[1, 3] = 8;

            matrix[2, 0] = 9;
            matrix[2, 1] = 10;
            matrix[2, 2] = 11;
            matrix[2, 3] = 12;
            return matrix;
        }

        [Test]
        public void ReplaceZeroInMatrix()
        {
            int[,] matrix = new int[3, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 0;
            matrix[0, 3] = 4;

            matrix[1, 0] = 0;
            matrix[1, 1] = 6;
            matrix[1, 2] = 7;
            matrix[1, 3] = 8;

            matrix[2, 0] = 9;
            matrix[2, 1] = 10;
            matrix[2, 2] = 11;
            matrix[2, 3] = 12;


            int[,] expectedMatrix = new int[3, 4];
            expectedMatrix[0, 0] = 0;
            expectedMatrix[0, 1] = 0;
            expectedMatrix[0, 2] = 0;
            expectedMatrix[0, 3] = 0;

            expectedMatrix[1, 0] = 0;
            expectedMatrix[1, 1] = 0;
            expectedMatrix[1, 2] = 0;
            expectedMatrix[1, 3] = 0;

            expectedMatrix[2, 0] = 0;
            expectedMatrix[2, 1] = 10;
            expectedMatrix[2, 2] = 0;
            expectedMatrix[2, 3] = 12;
            var result = MatrixHelper.ReplaceZeroInMatrix(matrix);
            Assert.AreEqual(expectedMatrix, result);
        }
    }
}
