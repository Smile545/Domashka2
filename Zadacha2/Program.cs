﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    string str = a.ToString();
    Console.WriteLine(str[2]);
}