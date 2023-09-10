// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10


string DecimalToBinary(int number)
{
    string binary = string.Empty;
    while (number > 0)
    {
        binary = number % 2 + binary;
        number = number / 2;
    }
    return binary;
}

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string binaryNumber = DecimalToBinary(decimalNumber);
Console.Write($"{decimalNumber} -> {binaryNumber}");