// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


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

int ReadInt(string text)    // запрашиваем на ввод данные
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string FindElement(int[,] matrix, int findRow, int findCol) // проверяем наличие искомой ячейки в матрице
{
    string element = "Такой ячейки нет";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == findRow && j == findCol) element = matrix[i, j].ToString();
        }
    }
    return element;
}


int rows = new Random().Next(3, 10);    // генерим рандомное кол-во строк
int cols = new Random().Next(3, 7);    // генерим рандомное кол-во стролбцов
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

int findRow = ReadInt("Введите номер строки матрицы: ");
int findCol = ReadInt("Введите номер столбца матрицы: ");
System.Console.WriteLine(FindElement(myMatrix, findRow, findCol));
