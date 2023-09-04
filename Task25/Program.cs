
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numbers (int A, int B)
{
    if (A == 0) return 0;
    int res = 1;
    for (int i = 0; i < B; i++)
        res *= A;
    return res;
}

  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int exp = numbers(A, B);
  Console.WriteLine("Ответ: " + exp);