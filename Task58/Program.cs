// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}



int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}

int [,] matrix1 = CreateMatrixRndInt1(2, 2, 0, 9);
int [,] matrix2 = CreateMatrixRndInt2(2, 2, 0, 9);
int[,] result = MultiplyMatrices(matrix1, matrix2);


int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j], 4}");
        }
        Console.WriteLine(" |");
        Console.WriteLine();
    }
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j], 4}");
        }
         Console.WriteLine(" |");
        Console.WriteLine();
    }
}


void PrintMatrixResult(int[,] result)
{ 
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
}

PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);

Console.WriteLine("Результирующая матрица будет:");
PrintMatrixResult(result);

