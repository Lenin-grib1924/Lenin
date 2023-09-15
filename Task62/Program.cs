// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



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

void EvenIndicesInASquare(int[,] matrix)
{
    int num = 1;
    int rowStart = 0;
    int rowEnd = 3;
    int colStart = 0;
    int colEnd = 3;
    {
        while (num <= 16)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = num;
                num++;
            }
            rowStart++;
            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = num;
                num++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = num;
                num++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = num;
                num++;
            }
            colStart++;
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < 4; i++)
    {
        // Console.Write("|   ");
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix[i, j].ToString("D2"),5}");
        }
        // Console.WriteLine("   |");
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixSumIndexes(4, 4);
EvenIndicesInASquare(matrix);
PrintMatrix(matrix);