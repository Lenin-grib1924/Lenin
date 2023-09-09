// Напишите программу, которая принимает на вход число N и выдает  произведение чисел от 1 до N

int MultiplicationNum(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i;
        }
    }
    return mult;
}


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 1)
{
    Console.WriteLine($"{number} - > некорректное число");
}
else
{
    int multNums = MultiplicationNum(number);
    Console.WriteLine($"{multNums} - > произведение чисел от 1 до {number}");
}


