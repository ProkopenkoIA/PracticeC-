
Console.Clear();

int A, i;

Console.Write("Введите значение А =");
A = Convert.ToInt32(Console.ReadLine());

for (i=1;i<=A;i++)
 {Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");}