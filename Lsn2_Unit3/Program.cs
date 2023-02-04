Console.Clear();

int A = new Random().Next(1,8);

Console.WriteLine("Номер дня недели = "+Convert.ToString(A));

if (A>6)
    {Console.WriteLine("Выходной");}
else 
    {Console.WriteLine("Не выходной");}