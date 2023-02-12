// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

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

// void FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             System.Console.WriteLine("Yes");
//             return;
//         }
//     }
//     System.Console.WriteLine("No");
//     return;
// }

// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] ==number)
//         {
//             return true;
//         }   
//     }
//     return false;
// }


int[] myArray = GenerateArray(5, 1, 9);
PrintArray(myArray);

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Array.IndexOf(myArray, N));

// if(FindNumber(myArray,N))
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
// System.Console.WriteLine("No");
// }