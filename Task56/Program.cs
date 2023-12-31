﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|   ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        // Console.WriteLine("   |");
        Console.WriteLine();
    }
}



int FindRowWithMinSum(int[,] matrix)

{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int minRowSum = int.MaxValue;
    int minRowIndex = -1;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < cols; j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;

}


int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);

int minRowIndex = FindRowWithMinSum(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRowIndex + 1}");