Console.Clear();

int [] berry;
int bush, i, max, sum, overSize;

Console.Write("Введите количество кустов = ");

max = 0;
overSize = 0;
bush = Convert.ToInt32(Console.ReadLine());

if (bush>3)
{
    overSize = 2;
}

berry = new int[bush+overSize];

if (bush<3 || bush>1000)
{Console.Write("Ошибка ввода"); return;}


for (i = 0; i<=bush-1;i++)
{
    Console.Write($"Введите количество ягод {i+1} куста = ");    
    berry[i] = Convert.ToInt32(Console.ReadLine());

    if (berry[i] >1000)
    {Console.Write("Ошибка ввода"); return;}
}
//-- добавляем к исходному массиву дополнительные значения, требуемые для сравнения при прохождении "кольца"
//-- необходимо, чтобы сравнить тройку кустов 4-1-2
if (overSize>0)
{
    berry[bush] = berry[0];
    berry[bush+1] = berry[1];
    overSize = 0;
}
else
{
     overSize = -2;
}

for (i = 1; i<=bush+overSize;i++)
{      
    sum = berry[i-1]+berry[i]+berry[i+1];

    if (sum>max)
    {
        max = sum;
    }
}

Console.WriteLine($"Максимальное количество ягод = {max}");