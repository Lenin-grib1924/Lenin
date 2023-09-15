﻿// Задайте двумерный массив размером m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведит полученный массив на экран.

int[,] CreateMatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            Console.Write($"{matrix[i, j], 5}");
        }
        // Console.WriteLine("   |");
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixSumIndexes(3,4);
PrintMatrix(matrix);