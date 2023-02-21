// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

double funX (double k1, double k2, double b1, double b2)

{
    double x;

    x = (b2-b1)/(k1-k2);
    return x;
}

double funy (double k, double b, double x)

{
    double y;

    y = k * x + b;
    return y;
}



double b1, k1, b2, k2, x, y1, y2;

Console.Write("Задайте b1 = ");

b1= Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте k1 = ");

k1= Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте b2 = ");

b2= Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте k2 = ");

k2= Convert.ToInt32(Console.ReadLine());

x = funX(k1, k2, b1, b2);

y1 = funy(k1, b1, x);
y2= funy(k2, b2, x);

Console.WriteLine($"[{y1},{y2}]");


