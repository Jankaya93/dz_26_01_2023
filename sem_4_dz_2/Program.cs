//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// ===== Вариант 1
// int GetNumber(string text)  // запрос исходного числа с текстом из вызова функции
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int NumberLen(int a) // считаем количество цифр в числе делением на 10
// {
//     int count = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         count++;
//     }
//     return count;
// }

// void SumNumbers(int n, int len) //подсчитываем сумму цифр числа
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// int number = GetNumber("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// ===== Вариант 2
string? GetNumber(string text)  // запрос исходного числа с текстом из вызова функции
{
    Console.Write(text);
    return Console.ReadLine();
}

int SumNumbers(string number)  // сумма цифр числа с одновременным переводом из чар в инт.
{   
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
    }
    return sum;
}

string? number = GetNumber("Введите число: ");
System.Console.WriteLine(SumNumbers(number));

