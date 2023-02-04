Console.Clear();

int A = Convert.ToInt32(Console.ReadLine()), MaxValue, SecondMaxValue;

MaxValue = A;
SecondMaxValue = 0;

while (A!=0)
{
    A = Convert.ToInt32(Console.ReadLine());
    //-- Сначала установим новым максимум
    if (A>MaxValue)
    {
        SecondMaxValue = MaxValue;
        MaxValue = A;
    }
    //-- Потом проверим второй максимум
    //-- похоже на не совсем оптимальное решение, но эта проверка необходима, например в случае 8 15 99 73 16 2 0
    else 
    {
        if (SecondMaxValue<A)
        {
            SecondMaxValue = A;     
        }
    }
        
}

Console.WriteLine("Ответ: "+Convert.ToString(SecondMaxValue));

