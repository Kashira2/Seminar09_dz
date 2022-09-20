// Функциия Аккермана для двух неотрицательных чисел.

int Akkerman(int n, int m)
{
    int result = 0;
    if (n == 0)
    {
        result = m + 1;
        return result;
    }
    else if (n != 0 && m == 0)
    {
        return Akkerman(n - 1, 1);
    }
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

try
{
    Console.Write("Введите первое положительное число число n: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите второе положительное число m: ");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine(Akkerman(n, m));
}
catch
{
    Console.WriteLine("Вводите целочисленные значения");
}