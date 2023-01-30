// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.Write("Введите число N1: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N2: ");
int cislo_2 = Convert.ToInt32(Console.ReadLine());

if (cislo_1 % cislo_2 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {cislo_1 % cislo_2}");
}