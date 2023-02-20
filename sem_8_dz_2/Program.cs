// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] GenerateMatrix(int rows, int cols)
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

int[] SumRows(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int total = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            total = total + matrix[i, j];
        }
        sumRows[i] = total;
    }
    return sumRows;
}

void MinSumRow(int[] VseSummyRows)
{
    int minSum = VseSummyRows[0];
    int minRow = 0;
    for (int i = 0; i < VseSummyRows.Length; i++)
    {
        if (minSum > VseSummyRows[i])
        {
            minSum = VseSummyRows[i];
            minRow = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов № {minRow+1}. Ее сумма = {minSum}");
}

int rows = new Random().Next(3, 7);
int cols = new Random().Next(3, 7);

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();
int[] VseSummyRows = SumRows(myMatrix);
MinSumRow(VseSummyRows);
