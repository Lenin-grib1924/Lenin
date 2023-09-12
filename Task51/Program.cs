// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной даиногали (с индексами (0,0); (1,1) и т.д.



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

int SumBothCommonIndexes(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int size = rows < columns ? rows : columns;
    int sum = 0;
    int j = 0;

    for (int i = 0; i < size; i++)
    {
        j = i;
        sum += matrix[i, i];
    }
    return sum;
}

int[,] matrix = CreateMatrixRndInt(5, 3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();

int sumBothCommonIndexes = SumBothCommonIndexes(matrix);

Console.WriteLine(sumBothCommonIndexes);