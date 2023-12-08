using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] matrix2 = { { 7, 8, 9 }, { 6, 5, 4 } };

        int[,] matrix3 = AddMatrixes(matrix1, matrix2 );

        PrintMatrix(matrix3 );
    }

    static int[,] AddMatrixes(int[,] matrixOne, int[,] matrixTwo)
    {
        int rows = matrixOne.GetLength(0);
        int cols = matrixOne.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrixOne[i, j] + matrixTwo[i, j];
            }
        }
        return resultMatrix;
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i<rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}