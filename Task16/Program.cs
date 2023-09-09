// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool CheckSquareTwoNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber;
}

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquareTwoNumbers(num1, num2);
Console.WriteLine(result? "Да" : "Нет");