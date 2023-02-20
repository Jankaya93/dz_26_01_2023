// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] GenerateOneMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateTwoMatrix(int[,] matr)
{
    Random rand = new Random();
    int[,] vertical = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < vertical.GetLength(0); i++)
    {
        for (int j = 0; j < vertical.GetLength(1); j++)
        {
            vertical[i, j] = rand.Next(0, 10);
        }
    }
    return vertical;
}

void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] resultMatrix)
{
    int sum = 0;
    for (int i = 0; i < martrix1.GetLength(1); i++)
    {
        for (int j = 0; j < martrix2.GetLength(0); j++)
        {
            sum = 0;
            for (int r = 0; r < martrix2.GetLength(0); r++)
            {
                sum += martrix1[i, r] * martrix2[r, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int rows = new Random().Next(3, 7);
int cols = new Random().Next(3, 7);

var myMatrix1 = GenerateOneMatrix(rows, cols);
PrintMatrix(myMatrix1);
System.Console.WriteLine();

var myMatrix2 = GenerateTwoMatrix(myMatrix1);
PrintMatrix(myMatrix2);
System.Console.WriteLine();

int[,] resultMatrix = new int[myMatrix1.GetLength(1), myMatrix2.GetLength(0)];
MultiplyMatrix(myMatrix1, myMatrix2, resultMatrix);
PrintMatrix(resultMatrix);
