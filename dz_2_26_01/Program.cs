// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите число N1: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N2: ");
int cislo_2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N3: ");
int cislo_3 = Convert.ToInt32(Console.ReadLine());

if(cislo_1>cislo_2 && cislo_1>cislo_3)
{
    System.Console.WriteLine("max = " + cislo_1);
}
else if(cislo_2>cislo_1 && cislo_2>cislo_3)
{
    System.Console.WriteLine("max = " + cislo_2);
}
else if (cislo_3>cislo_1 && cislo_3>cislo_2)
{
    System.Console.WriteLine("max = " + cislo_3);
}