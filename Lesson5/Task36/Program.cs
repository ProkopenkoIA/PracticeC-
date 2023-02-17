//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Clear();

int answer (int [] a)
{
    int i,b;
    b = 0;

    for (i=0; i<=a.Length-1; i++)
    {   
        if (i % 2 == 1)
        {
         b = b + a[i];
        }    
    
    }
    return b;

}

void new_array (int [] a)
{
    int i,b;
    for (i=0; i<=a.Length-1; i++)
    {   
    b =  new Random().Next(-10, 11);
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
Console.Write($"Сумма элементов на не четных похициях = {result}");