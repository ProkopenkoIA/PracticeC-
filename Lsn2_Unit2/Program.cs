Console.Clear();

int A = new Random().Next(10,100000), B, C, E, rtrn;

Console.WriteLine("Значение А = "+Convert.ToString(A));

B = (A/100);
C = 0;

if (B==0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{//-- Получим разрядность числа

    B = 3;
    rtrn = A;
    while (A>0)
    {
        A = A/10;

        C++;
    }
    
    //Console.WriteLine("Разрядность числа = "+Convert.ToString(C));

    E = Convert.ToInt32(Math.Pow(10, (C-B)));

    rtrn = (rtrn/E)%10; 
    
    Console.WriteLine("Третья цифра= "+Convert.ToString(rtrn));

    }


