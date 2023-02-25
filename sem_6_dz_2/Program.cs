// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int y1 = arr[1];
int y2 = arr[3];
int x1 = arr[0];
int x2 = arr[2];

void GetKoordinate(int[] arr)
{
    if (y1 == y2)
    {
        Console.WriteLine("Прямые с такими параметрами паралельны");
    }
    else
    {
        double pointX = (double)(x2 - x1) / (y1 - y2);
        double pointY = (double)y1 * (x2 - x1) / (y1 - y2) + x1;
        Console.WriteLine($"Точка пересечения прямых: Х: {pointX:0.00}; Y: {pointY:0.00}");
    }
}

GetKoordinate(arr);
