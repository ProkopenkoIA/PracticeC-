Console.Clear();

int Pow (int a, int b)
{
    int c, i;

    c = 1;

    for (i = 1; i<=b; i++)
    {
        c = c * a;
    }
    return c;

}

int a, b;

Console.Write("Введите значение A = ");

a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение B = ");

b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат {Pow(a,b)}");

