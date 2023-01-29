Console.Clear();

double A;
Console.WriteLine("Введите значение А");

A = Convert.ToDouble(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine(" Значение А - четное!");
}
else
{
   Console.WriteLine(" Значение А - не четное!"); 
}
