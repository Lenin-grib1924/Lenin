// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int Number (int A)
{
    int res = 0;
    while (A > 0)
    {
        res += A % 10;
        A = A / 10;
    }
    return res;
}

 Console.Write("Введите число: ");
  int numA = Convert.ToInt32(Console.ReadLine());

  int exp = Number(numA);
  Console.WriteLine($"Сумма цифр в числе {numA} - > {exp}");
