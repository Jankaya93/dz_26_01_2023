// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите число N1: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N2: ");
int cislo_2 = Convert.ToInt32(Console.ReadLine());

if(cislo_1<cislo_2)
{
    System.Console.WriteLine("Min = " + cislo_1 + "; Max = " + cislo_2);
}
else if(cislo_1>cislo_2)
{
    System.Console.WriteLine("Min = " + cislo_2 + "; Max = " + cislo_1);
}
else
    System.Console.WriteLine("Введенные числа равны");