Console.Clear();

int Sum (int a)
{
    string s, str;
    int  i, result;

    result = 0;

    str = Convert.ToString(a);

    //Console.Write($"{str.Length-1}"); 

    for (i = 0; i<=str.Length-1; i++)
    {
        s =  Convert.ToString(str[i]);  
        result = result +  Convert.ToInt32(s);
    }
    return result;

}


int a;

Console.Write("Введите значение A = ");

a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат {Sum(a)}");

