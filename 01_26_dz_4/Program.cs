// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число N: ");
int cislo = Convert.ToInt32(Console.ReadLine());

if(cislo>=1)
{
    for (int n = 2; n <= cislo; n += 2)
    {
    System.Console.Write(n + " ");
    }
}
else 
    System.Console.WriteLine("В задании не было условия что можно вводить отрицательные числа или 0");

