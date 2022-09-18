// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumRec(int num2, int num1)
{
    if (num2 == num1) return num1;
    else return num2 + SumRec(num2 - 1, num1);
}

try
{
Console.WriteLine("Введите первое число M: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(SumRec(num2, num1));
}
catch
{
    Console.WriteLine("Вводите целочисленные значения");
}