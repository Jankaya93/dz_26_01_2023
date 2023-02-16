// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со стороная такой длины.
// теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// ====== ВАРИАНТ 1
// System.Console.Write("Введите число N1: ");
// int cislo_1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число N2: ");
// int cislo_2 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число N3: ");
// int cislo_3 = Convert.ToInt32(Console.ReadLine());

// if (cislo_1 + cislo_2 > cislo_3 
//     && cislo_2 + cislo_3 > cislo_1 
//     && cislo_1 + cislo_3 > cislo_2 )
//     System.Console.WriteLine("yes");
//     else System.Console.WriteLine("no");


// ====== ВАРИАНТ 2
metka:
System.Console.WriteLine("Введите числа: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (array.Length != 3)
{
    System.Console.WriteLine("Массив введён некоректно ");
    goto metka;
}

if ((array[0] + array[1]) > array[2] 
    && (array[1] + array[2]) > array[0] 
    && (array[0] + array[2] > array[1]))
{
    System.Console.WriteLine("Такой треугольник существует ");
}
else System.Console.WriteLine("Такой треугольник не существует ");
