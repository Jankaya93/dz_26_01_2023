// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber()
{
    System.Console.Write("Введите количество чисел в будущем масиве: ");
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

int KolichestvoPolosgitelnyx (int [] array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) total ++; 
    }
    return total;
}

int size = GetNumber();
int[] arr = GenerateArray(size, -10, 10);
PrintArray(arr);
System.Console.WriteLine(KolichestvoPolosgitelnyx(arr));