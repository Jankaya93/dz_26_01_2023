// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] GenerateMatrix(int rows, int cols)    //генерим элементы матрицы целыми числами
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

void PrintMatrix(int[,] matrix)  // принтуем полную матрицу
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

int[] SumElementCols(int[,] matrix) // суммируем значения по столбикам, присваивая результат ячейке новой одинарной матрицы
{
    int size = (matrix.GetLength(1));
    int[] result = new int[size];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumElementCol = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumElementCol += matrix[i, j];
        }
        result[j] = sumElementCol;
    }
    return result;
}

void PrintArray(int[] result)   // принтуем одинарную матрицу
{
    System.Console.WriteLine(string.Join("\t", result));
}

int rows = new Random().Next(3, 7);    // генерим рандомное кол-во строк
int cols = new Random().Next(3, 7);    // генерим рандомное кол-во стролбцов
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintArray(SumElementCols(myMatrix));
