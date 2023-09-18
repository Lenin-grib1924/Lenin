// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int RangeNaturalNumbers(int from, int to)
{
    if(from == to) return from;
    else
    {
        return from + RangeNaturalNumbers (from + 1, to);
    } 
}

Console.WriteLine("Введите диапазон натуральных чисел");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

RangeNaturalNumbers(numberOne, numberTwo);

int sum = RangeNaturalNumbers(numberOne, numberTwo);
Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна: {2}", numberOne, numberTwo, sum);
