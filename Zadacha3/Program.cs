// Напишите программу, которая принимает на вход цифру, обозначающую день недели
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите  число ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 6:
        Console.WriteLine("Да");
        break;
    case 7:
        Console.WriteLine("Да");
        break;
    default:
        Console.WriteLine("Нет");
        break;
}
