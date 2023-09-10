// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() *  (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}



double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}


double [] array = CreateArrayRndDouble(5, 2, 22);
PrintArrayDouble(array);
Console.WriteLine();

double maxElem = MaxElem(array);
double minElem = MinElem(array);
double difference = maxElem - minElem;

Console.WriteLine($"Максимальный элемент массива - {maxElem:F1}");
Console.WriteLine($"Минимальный элемент массива - {minElem:F1}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {difference:F1}");

