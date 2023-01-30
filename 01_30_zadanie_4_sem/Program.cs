// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.Write("Введите число N: ");
int cislo = Convert.ToInt32(Console.ReadLine());

if (cislo % 7 == 0 && cislo % 23 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine("нет");
}