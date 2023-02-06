// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму числе от 1 до А.
// 7 - 28
// 4 -10 (1+2+3+4)

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumElements(int A)
{
    int result = 0;

    for (int i = 1; i <= A; i++)
    {
         result += i;
    }
    return result;
}

int num = GetNumber("Введите число А: ");

System.Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumElements(num)}");