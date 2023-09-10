// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} -й элемент: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество элементов массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
// int [] arr;
// arr = CreateArray[n];
int[] array;
array = CreateArray(lenght);
PrintArray(array);
Console.WriteLine();

int countPositiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0 = {countPositiveNumbers}");

