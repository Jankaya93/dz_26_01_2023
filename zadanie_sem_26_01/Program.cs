// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


System.Console.Write("Введите предполагаемый квадрат числа: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите проверяемое число: ");
int cislo_2 = Convert.ToInt32(Console.ReadLine());

if(cislo_2*cislo_2==cislo_1)
{
    System.Console.WriteLine("Yes");
}
else
System.Console.WriteLine("No");