﻿// Задайте массив. Напишите программу, которая  определяет, присутствует ли заданное число в массиве


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

bool AvailabilityNumber(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            return true;
        }
    }
    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = AvailabilityNumber(array, num);

Console.WriteLine(res ? "да" : "нет");