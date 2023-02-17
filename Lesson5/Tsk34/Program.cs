//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();

int answer (int [] a)
{
    int i,b;
    b = 0;

    for (i=0; i<=a.Length-1; i++)
    {   
        if (a[i] % 2 == 0)
        {
         b++;
        }    
    
    }
    return b;

}

void new_array (int [] a)
{
    int i,b;
    for (i=0; i<=a.Length-1; i++)
    {   
    b =  new Random().Next(100,1000);
    a[i] = b;
    }
}

int a, result;

Console.Write("Задайте длину массива = ");

a = Convert.ToInt32(Console.ReadLine());

int [] array = new int [a];

new_array(array);

Console.WriteLine($"{string.Join(" ,",array)}");

result = answer(array);
Console.Write($"Количество четных элементов = {result}");

