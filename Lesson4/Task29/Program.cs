Console.Clear();

int a, i, b;

Console.Write("Введите количество учеников = ");
a = Convert.ToInt32(Console.ReadLine());

int [] array = new int [a];

for (i=0; i<=a-1; i++)
{   
   b =  new Random().Next(160,201);
   array[i] = b;
}

Array.Sort(array);
Array.Reverse(array);
Console.WriteLine($"{string.Join(" ,",array)}");

Console.Write("Введите рост Пети = ");
b = Convert.ToInt32(Console.ReadLine());

for (i=0; i<=a-1; i++)
{  
    if (b>array[i])
    {
        Console.WriteLine($" Позиция Пети = {i+1}");     
        return; 
    }
}

Console.WriteLine($" Позиция Пети = {i+1}"); 

