// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, double leftRange, double rightRange)   // Создание массива с рандомными вещественными числами в мин/мах диапазоне
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * ((rightRange - leftRange) + leftRange), 2);
    }
    return array;
}

void PrintArray(double[] array)     // вывод в терминал массива
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double maxNumber(double[] array)    // нахождение максимального числа в массиве
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double minNumber(double[] array)    // нахождение минимального числа в массиве
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double GetResult(double maxNumber, double minNumber)    // вычисление разницы между максимальным и минимальным элементом
{
    double reznica = maxNumber - minNumber;
    return reznica;
}

double[] myArray = GenerateArray(5, 0.0, 10.0);
PrintArray(myArray);
System.Console.WriteLine(GetResult(maxNumber(myArray), minNumber(myArray)));


// ====== Работающий вариант с целыми числами
// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// int maxNumber(int[] array)
// {
//     int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }

// int minNumber(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }

// int GetResult(int maxNumber, int minNumber)
// {
//     int reznica = maxNumber - minNumber;
//     return reznica;
// }


// int[] myArray = GenerateArray(5, -20, 20);
// PrintArray(myArray);
// System.Console.WriteLine(GetResult(maxNumber(myArray), minNumber(myArray)));