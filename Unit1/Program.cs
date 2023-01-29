Console.Clear();

int A, B;
Console.WriteLine("Введите значение А");

A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение B");

B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A = "+ Convert.ToString(A));
Console.WriteLine("B = "+ Convert.ToString(B));

if (A>B)
{
    Console.WriteLine(" Результат: A больше B");
}
else
{
    if (A!=B)
    {
        Console.WriteLine(" Результат: B больше A");
    } 
    else
        Console.WriteLine(" Числа равны");
}

