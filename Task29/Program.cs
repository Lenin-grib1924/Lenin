// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


class Program
{
    static void Main(string[] args)
    {
        //static void Task29()
        {
            var ar = new string[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                var item = Console.ReadLine();
                Console.WriteLine();

                if (string.IsNullOrWhiteSpace(item))
                    break;

                ar[i] = item;
            }

            Console.WriteLine($"[{string.Join(", ", ar.Where(s => !string.IsNullOrEmpty(s)))}]");
        }
    }
}