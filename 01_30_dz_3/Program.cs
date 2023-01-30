// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите номер дня недели: ");
int cislo = Convert.ToInt32(Console.ReadLine());

if(cislo>0 && cislo<8)
{
    if(cislo==6 || cislo==7)
    {
        System.Console.Write("да");
    }
    else
    {
        System.Console.Write("нет");
    }
}
else
{
    System.Console.Write("Ну и где вы видели недели такой длины?");
}
