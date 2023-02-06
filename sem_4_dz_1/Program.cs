// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Введите число А: ");
int stepen = GetNumber("Введите число B: ");

System.Console.WriteLine($"Число {num} в степени {stepen} = {Math.Pow(num, stepen)}");