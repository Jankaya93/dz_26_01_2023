// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




int [] GetArray()
{
    int[] arr = new int[8];
    var rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
         arr[i] = rand.Next(0,2);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    // for (int i = 0; i <  arr.Length; i++)
    // {
    //      System.Console.Write(arr[i] + " ");
    // }
    System.Console.WriteLine("["+string.Join(" ", arr)+"]");
}

var myArray = GetArray();
PrintArray(myArray);


// ===== Вариант 2
// int n = 8;
// int[] arr = GetArray(n);

// int[] GetArray(int n)
// {
//     int[] array = new int[n];
//     Random rand = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = rand.Next(0, 2);
//     }
//     return array;
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }



// ===== Вариант 3
// void GetArray(int[] arr)
// {
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("["+string.Join(", ", arr)+"]");
// }

// int[] myArray = new int[8];
// GetArray(myArray);
// PrintArray(myArray);

// ====== Вариант 4
// int[] GetArray()
// {
//     var arr = new int[8];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("["+string.Join(", ", arr)+"]");
// }

// var myArray = GetArray();
// PrintArray(myArray);