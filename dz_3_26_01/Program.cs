// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число N: ");
int cislo = Convert.ToInt32(Console.ReadLine());

if(cislo%2 == 0)
{
    System.Console.WriteLine("Yes");
}
else
    System.Console.WriteLine("No");