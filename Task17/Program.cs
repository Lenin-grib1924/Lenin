// Напишите программу, которая принимает на вход координаты точки (Х и У), причем Х не рано 0 и У не равно 0
// и выдает номер четверти плоскости, в которой находится эта точка.

int Quarter(int x, int y) // метод
{
    if(x > 0 && y > 0) return 1; // функция
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти - > {quarter}"
                : "Введены некорректные данные";
Console.WriteLine(result);


