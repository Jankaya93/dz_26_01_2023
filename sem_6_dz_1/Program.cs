// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber(string text)
{
    System.Console.WriteLine("Введите количество чисел в будущем масиве");
    return Convert.ToInt32(Console.ReadLine());
}

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


void PrintArray(int[] arr)
{
    System.Console.WriteLine("["+string.Join(" ", arr)+"]");
}


int size = GetNumber();
int[] arr = GenerateArray(size, 0, 100);
PrintArray(arr);