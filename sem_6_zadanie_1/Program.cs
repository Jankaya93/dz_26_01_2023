// Задача 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и тд)
// [1,2,3,4,5] -> [5,4,3,2,1]


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

void ReverseArray(int[] arr)    // альтернативный переворот массива 
{
    int temp;
    for (int i = 0; i < arr.Length/2; i++)  // обязательно /2, иначе будет двойной переворот равный первоначальному
    {
        temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
    }
}

int[] arr = GenerateArray(10, 0, 100);
PrintArray(arr);
// ReverseArray(arr);   // применение метода альтернативного переворота массива
Array.Reverse(arr);
PrintArray(arr);