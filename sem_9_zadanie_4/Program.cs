// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetResult(int a, int b)

{
    if (b == 1) return a;
    return a * GetResult(a, b -1);  // "b--" нельзя использовать, ошибка стак оверфлоу
}

// int GetResult(int numA, int numB, int res)   // вариант Дениса с семинара
// {
//     numB--;
//     if (numB >= 0)
//     {
//         res = res * numA;
//         return GetResult(numA, numB, res);
//     }
//     else
//     {
//         return res;
//     }
// }

int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
System.Console.WriteLine(GetResult(numA, numB));
