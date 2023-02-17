
//Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33



Console.Clear();

void answer (double [] a, ref double min, ref double max)
{
    int i;    

    for (i=1; i<=a.Length-1; i++)
    {   
        if (a[i] < min)
        {
         min = a[i];
        }  

        if (a[i] > max)
        {
         max = a[i];
        }  
    
    }
}

void new_array (double [] a)
{
    int i;
    double b;
    Random rnd;
    rnd = new Random();

    for (i=0; i<=a.Length-1; i++)
    {   
        b =  Math.Round(rnd.NextDouble()*30, 2);
        a[i] = b;
    }
}

int a;
double min, max;

Console.Write("Задайте длину массива = ");

a = Convert.ToInt32(Console.ReadLine());

double [] array = new double [a];

new_array(array);

max = array[0];
min = array[0];

Console.WriteLine($"{string.Join(", ",array)}");

answer(array, ref min, ref max);

Console.Write($"Разница мужду max ({max}) и min ({min}) = {max - min}");
