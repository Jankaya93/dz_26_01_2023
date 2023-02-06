// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// ===== вариант 1
// void Palindrom(string? vvod)
// {
//     int len = vvod.Length;

//     if (len == 5)
//     {
//         if (vvod[0] == vvod[4] && vvod[1] == vvod[3])
//         {
//             System.Console.WriteLine("да");
//         }
//         else
//             System.Console.WriteLine("нет");
//     }
// else
//     System.Console.WriteLine("Внимательнее читайте требование к вводу");
// }

// System.Console.Write("Введите пятизначное число N: ");
// string? vvod = Console.ReadLine();

// Palindrom(vvod);



// ====== Вариант 2
// System.Console.Write("Введите пятизначное число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 10000 / 1000)
// {
//     System.Console.WriteLine("да");
// }
// else
// {
//     System.Console.WriteLine("нет");
// }