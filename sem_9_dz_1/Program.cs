﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNatural(int numM, int numN)
{
    if (numM > numN) return numN;
    return numN + SumNatural(numM, numN - 1); 
}


int numM = ReadInt("Введите число M: ");
int numN = ReadInt("Введите число N: ");

System.Console.WriteLine(SumNatural(numM, numN));