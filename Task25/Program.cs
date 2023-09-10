
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Numbers (int A, int B)
{
    if (A == 0) return 0;
    int res = 1;
    for (int i = 0; i < B; i++)
        res *= A;
    return res;
}

  Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  if (numB < 1)
  {
    Console.WriteLine("Число В не может быть отрицательным");
    return;
  }

  int exp = Numbers(numA, numB);
  Console.WriteLine($"Число {numA} встепени {numB} равно {exp}");