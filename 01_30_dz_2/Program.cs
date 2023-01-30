// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число N: "); // ввели любое число
string? vvod = Console.ReadLine();
int dlina = vvod!.Length;   // нашли количество цифр в числе

int cislo = Convert.ToInt32(vvod); // перевели из строки число в целое
// System.Console.WriteLine(dlina);

float kol = MathF.Pow(10,(dlina-3)); // нашли на сколько нужно поделить чтоб осталось 3 цифры
int kolih = Convert.ToInt32(kol);

// System.Console.WriteLine(kolih);

if (dlina > 3)    //  проверка введенного числа по длине
{
        System.Console.Write((cislo / kolih) % 10);
}
else if (dlina == 3) 
{
    System.Console.Write(cislo % 10);
}
else
{
    System.Console.Write("третьей цифры нет");
}
