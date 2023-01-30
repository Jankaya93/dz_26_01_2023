// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.Write("Введите число N: ");
int cislo = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (cislo > 99 && cislo < 1000)
{
    System.Console.WriteLine("Последняя цифра вашего числа: " + cislo%10);
}
else
System.Console.WriteLine("Введено не трехзначное число");

