// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m. 
// n = 2, m = 3 -> A(n,m) = 9

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double ResultAkkerman(double n, double m)
{
    if (n == 0)
        return m + 1;
    else
    {
        if ((n != 0) && (m == 0))
            return ResultAkkerman(n - 1, 1);
        else
            return ResultAkkerman(n - 1, ResultAkkerman(n, m - 1));
    }
}

int numN = ReadInt("Введите число N: ");
int numM = ReadInt("Введите число M: ");

System.Console.WriteLine(ResultAkkerman(numN, numM));