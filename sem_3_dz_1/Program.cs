// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

void Palindrom(string? vvod)
{
    int len = vvod.Length;

    if (len == 5)
    {
        if (vvod[0] == vvod[4] && vvod[1] == vvod[3])
        {
            System.Console.WriteLine("да");
        }
        else
            System.Console.WriteLine("нет");
    }
else
    System.Console.WriteLine("Внимательнее читайте требование к вводу");
}

System.Console.Write("Введите пятизначное число N: ");
string? vvod = Console.ReadLine();

Palindrom(vvod);
