// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

Console.Clear();

int calc (int [] arr)
{
    int i, b=0;  

    for(i=0; i<=arr.Length-1; i++)
    {
        if (arr[i]>0)
        {
            b++;
        }
    }

    return b;
}

Console.WriteLine("Введите строку чисел через пробел...");
int [] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();


Console.WriteLine($"[{string.Join(", ",numbers)}]");

Console.WriteLine($"Числе болше ноля - {calc(numbers)}");
