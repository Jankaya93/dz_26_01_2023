// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// ====== ВАРИАНТ 1
// System.Console.Write("Введите число N: ");
// int cislo_1 = Convert.ToInt32(Console.ReadLine());
// string Number = "";
// while (cislo_1 > 0)
// {
//     Number = Number + cislo_1 % 2;
//     cislo_1 = cislo_1 / 2;
// }

// for (int i = Number.Length - 1; i >= 0; i--) System.Console.Write(Number[i]);


// ====== ВАРИАНТ 2     // нельзя использовать для больших цифр, т.к. будет перегружена память
// void GetBinatyView(int number)
// {
//     if (number <= 0) return;
//     GetBinatyView(number / 2);
//     System.Console.Write(number % 2);
// }

// System.Console.Write("Введите число N: ");
// int cislo_1 = Convert.ToInt32(Console.ReadLine());
// GetBinatyView(cislo_1);


// ====== ВАРИАНТ 3
System.Console.Write("Введите число N: ");
int cislo_1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Convert.ToString(cislo_1, 2));