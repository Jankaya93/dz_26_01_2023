﻿// Задача 60: Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] GenerateMatrix(int rows, int cols, int wol)
{
    Random rand = new Random();
    int[,,] matrix = new int[rows, cols, wol];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                {
                    matrix[i, j, k] = rand.Next(10, 100);
                }
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                {
                    System.Console.WriteLine($"{matrix[i, j, k]} с индексом [{i}, {j}, {k}]");
                }
            }
        }

        System.Console.WriteLine();
    }
}

int rows = new Random().Next(3, 7);
int cols = new Random().Next(3, 7);
int wol = new Random().Next(3, 7);

var myMatrix = GenerateMatrix(rows, cols, wol);
PrintMatrix(myMatrix);