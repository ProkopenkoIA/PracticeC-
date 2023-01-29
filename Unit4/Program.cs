
Console.Clear();

double A;
string S = "";

Console.Write("Введите значение А ");

A = Convert.ToDouble(Console.ReadLine());


for (int i = 1; i<Convert.ToInt32(A); i++)
{
    if (i % 2 == 0)
    {
       S = S + Convert.ToString(i)+" "; 
    }

}

Console.WriteLine(" Все четные от 1 до "+Convert.ToString(A)+": "+S);
