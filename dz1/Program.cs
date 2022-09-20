//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


string NumberFor(int num2, int num1)
{
    if (num2 == num1) return $"{num1}";
    else return NumberFor(num2 - 1, num1) + $" {num2}";
}

try
{
    Console.WriteLine("Введите первое число M: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число N: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(NumberFor(num2, num1));
}
catch
{
    Console.WriteLine("Вводите целочисленные значения");
}