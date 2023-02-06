// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

       

System.Console.Write("Введите число N: ");
string? vvod = Console.ReadLine();

if (int.TryParse(vvod,out int i))
{
    System.Console.Write(vvod!.Length);
}
else
{
    System.Console.Write("Ввели не цифры.");
}


// string input = "141241";
// int ouput;
// bool result = int.TryParse(input, out output);


// System.Console.Write("Введите число N: ");
// System.Console.Write(Console.ReadLine()!.Length);
