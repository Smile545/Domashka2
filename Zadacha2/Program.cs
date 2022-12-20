// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (a < 1000)
{
    Console.WriteLine(a % 10);
}
else if (a < 10000)
{
    Console.WriteLine((a % 100) / 10);
}
else if (a < 100000)
{
    Console.WriteLine((a % 1000) / 100);
}

