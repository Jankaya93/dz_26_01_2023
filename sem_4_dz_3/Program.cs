//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray()
{
    int[] arr = Console.ReadLine().Split("").Select(int.Parse).ToArray();
    return arr;
}


void PrintArray(int[] ray)
{
    System.Console.WriteLine("[" + string.Join(", ", ray) + "]");
}

var myArray = GetArray();
PrintArray(myArray);
