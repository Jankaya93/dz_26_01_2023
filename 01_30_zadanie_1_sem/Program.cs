// написать программу, которая выводит случайно число из отрезка 10 - 99 и показывает наибольшую цифру числа.

Random rand = new Random(); //чтоб покороче писать вывод рандома дальше по коду (если несколько раз нужно)
int number = rand.Next(10, 100);

System.Console.WriteLine($"Случайное число: {number}");


if (number / 10 > number % 10)
{
    System.Console.WriteLine(number / 10);
}
else if (number / 10 < number % 10)
{
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Цифры числа одинаковые");
}