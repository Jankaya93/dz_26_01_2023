// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.Write("Введите количество чисел N: ");
int length = Convert.ToInt32(Console.ReadLine());
int cislo_1 = 0;
int cislo_2 = 1;

System.Console.Write("0 1 ");

for (int i = 0; i < length - 2; i++)
{
    int Febonachi = cislo_1 + cislo_2;
    System.Console.Write($"{Febonachi} ");
    cislo_1 = cislo_2;
    cislo_2 = Febonachi;
}