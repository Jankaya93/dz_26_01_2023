﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int GetResult(int[] array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            total++;
        }
    }
    return total;
}


int[] myArray = GenerateArray(30, 100, 1000);
PrintArray(myArray);
System.Console.WriteLine(GetResult(myArray));