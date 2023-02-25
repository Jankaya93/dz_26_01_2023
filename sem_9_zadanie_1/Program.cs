// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// void PrintChisla(int num)    // вариант 1 через фор
// {
//     for (int i = 1; i < num + 1; i++)
//     System.Console.Write(i + " ");
// }

void PrintChisla(int num)   // вариант 2 через рекурсию
{
    if (num < 1) return;
    PrintChisla(num - 1);
    System.Console.Write(num + " ");
}

int chisloN = ReadInt("Введите число N: ");
PrintChisla(chisloN);