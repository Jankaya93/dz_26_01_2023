// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


System.Console.Write("Введите число N1: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N2: ");
int cislo_2 = Convert.ToInt32(Console.ReadLine());

if (cislo_1 * cislo_1 ==  cislo_2 || cislo_2 * cislo_2 ==  cislo_1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}