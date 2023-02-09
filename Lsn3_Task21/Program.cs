Console.Clear();

double x1, x2, y1, y2, z1, z2, result;

Console.Write("Введите значение x1 = ");

x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение y1 = ");

y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение z1 = ");

z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение x2 = ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение y2 = ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение z2 = ");
z2 = Convert.ToDouble(Console.ReadLine());

result = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),2);

Console.WriteLine($"Расстояние между точками = {result}");