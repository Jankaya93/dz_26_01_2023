// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintChisla(int numIn, int numFor)
{
    if (numFor < numIn) return;     // условие выхода из цикла, пока не вышло из цикла делает ниже указанные действия полностью по очереди.
    PrintChisla(numIn, numFor - 1);     // проходим по всем значениям по порядку уменьшения
    System.Console.Write(numFor + " ");     // вывод в консоль в обратном порядке, с последнеего выполненного до первоначального значения
}

int numIn = ReadInt("Введите начальное число: ");   // m
int numFor = ReadInt("Введите конечное число: ");   // n

PrintChisla(numIn, numFor);