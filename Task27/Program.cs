// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int number (int A)
{
    int res = 0;
    while (A>0)
    {
        res += A%10;
        A /= 10;
    }
    return res;
}

 Console.Write("Введите число: ");
  int A = Convert.ToInt32(Console.ReadLine());

  int exp = number(A);
  Console.WriteLine("Сумма цифр в числе: " + exp);
