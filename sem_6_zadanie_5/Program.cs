// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

// int[] CopyPaste(int[] array)    // вариант 1
// {
//     int[] array2 = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array2[i] = array[i];
//     }
//     return array2;
// }

int[] arr = GenerateArray(7, 1, 100);
PrintArray(arr);
arr[0] = 100;
// PrintArray(CopyPaste(arr));
int[] arrCopy = arr[..];    // вармант 2. так создавать копию можно (точки обязательны!) 

PrintArray(arrCopy);
