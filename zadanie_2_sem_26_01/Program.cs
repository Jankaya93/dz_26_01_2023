// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.Write("Введите номер дня недели по счету: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресение");
        break;
    default:
        System.Console.WriteLine("Такого дня недели не существует!");
        break;
}

// if (day == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if (day == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if (day == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if (day == 4)
// {
//     System.Console.WriteLine("Четверг");
// }
// else if (day == 5)
// {
//     System.Console.WriteLine("Пятница");
// }
// else if (day == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// else if (day == 7)
// {
//     System.Console.WriteLine("Воскресение");
// }
// else
// System.Console.WriteLine("Такого дня недели не существует!");