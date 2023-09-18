﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    System.Console.WriteLine("Некорректнй ввод!");
    return;
}

int count = 1;
NaturalNumbers(number, count);



void NaturalNumbers(int n, int count)
{
    if (count > n) return;
    else
    {
        NaturalNumbers(n, count + 1);
        Console.Write($"{count} ");
    }
}
