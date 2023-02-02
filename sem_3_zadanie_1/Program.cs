// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputNumber(string str) 
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void FindQuarter(int a, int b)  // данные передаваемые через файндквартер будут подставлены в том же порядке вместо а и б.
{
    if (a > 0 && b > 0)
{
    System.Console.WriteLine("Номер четверти 1");
}
else if (a < 0 && b > 0)
{
    System.Console.WriteLine("Номер четверти 2");
}
else if (a < 0 && b < 0)
{
    System.Console.WriteLine("Номер четверти 3");
}
else if (a > 0 && b < 0)
{
    System.Console.WriteLine("Номер четверти 4");
}

}

FindQuarter(InputNumber("Введите координату Х: "),InputNumber("Введите координату Y: "));