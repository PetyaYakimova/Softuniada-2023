namespace RotateMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] finalMatrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] inputMatrixRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    finalMatrix[j, matrixSize-1-i] = inputMatrixRow[j];
                }
            }


            //Prinnt the result matrix
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(finalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}