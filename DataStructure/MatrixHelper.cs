using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MatrixHelper
    {
        // Rotate Matrix
        public static int[,] RotateMatrix(int[,] inputMatrix, Rotate rotateAngle)
        {
            int rotateCount = (int)rotateAngle / 90;
            int[,] result = inputMatrix;
            while (rotateCount > 0)
            {
                result = RotateMatrix90Degree(result);
                rotateCount--;
            }
            return result;
        }

        //
        private static int[,] RotateMatrix90Degree(int[,] inputMatrix)
        {
            if (inputMatrix == null) throw new Exception("Invalid input");
            // r x c matrix will become c x r diamansion
            int[,] rotatedMatrix = new int[inputMatrix.GetLength(1), inputMatrix.GetLength(0)];

            int newColumn = 0;
            int newRow = 0;
            for (int oldColumn = inputMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < inputMatrix.GetLength(0); oldRow++)
                {
                    rotatedMatrix[newRow, newColumn] = inputMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }

            return rotatedMatrix;
        }


        // Replace zero for all row and column value if any one of the value is Zero in row / column
        public static int[,] ReplaceZeroInMatrix(int[,] matrix)
        {
            bool[] rowZeros = new bool[matrix.GetLength(0)];
            bool[] columnZeros = new bool[matrix.GetLength(1)];

            // Mark which row and column value has zero value
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    if (matrix[rowIndex, columnIndex] == 0)
                    {
                        rowZeros[rowIndex] = true;
                        columnZeros[columnIndex] = true;
                    }
                }
            }

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    // Check current row / column value has zero value
                    if (rowZeros[rowIndex] == true || columnZeros[columnIndex] == true)
                    {
                        // Replace zero 
                        matrix[rowIndex, columnIndex] = 0;
                    }
                }
            }

            return matrix;

        }

    }
}
