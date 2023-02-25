// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// int SumNumbers(int num, int sum)        // вариант 1
// {
//     sum += num % 10;
//     if (num / 10 == 0) return sum;
//     return SumNumbers(num / 10, sum);
// }

int chisloN = ReadInt("Введите число N больше 10: ");

// System.Console.WriteLine(SumNumbers(chisloN, 0));


int SumNumbers(int n)        // вариант 2
{
    if (n == 0) return 0;
    return n % 10 + SumNumbers(n / 10);
}

System.Console.WriteLine(SumNumbers(chisloN));