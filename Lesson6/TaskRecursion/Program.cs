// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.
Console.Clear();

void PrintPerm(int [] a, char [] answer,int n) 
{
    for (int i = 0; i<n; i++)
    {
        Console.Write(answer[a[i]-1]);
    }
    Console.WriteLine();
}

void GenPerm(int [] a, int [] b, char [] answer, int i, int n)
{

    if (i == n)
    {
        PrintPerm(a,answer, n);
    }
    else
    {
        int j;
        for (j = 0; j < n; j++)
        {
            if (b[j] == 0)
            {
                b[j] = 1;
                a[i] = j + 1;
                
                GenPerm(a, b,answer, i + 1, n);
                
                b[j] = 0;
            }
        }
    }

}

char[] new_array(string str)
{
    char[] a = str.ToCharArray();
    return a;
}

string str;

Console.WriteLine("Vvedite stroku cimvolov");

str = Console.ReadLine();

char [] answer = new_array(str);
int [] symbols = new int [answer.Length];//Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();//new_array(str);
int [] arr = new int [symbols.Length];

//Console.WriteLine($"[{string.Join(", ",symbols)}]");

Console.WriteLine();

GenPerm (symbols, arr, answer, 0, symbols.Length); /* первый вызов генератора */

//Console.WriteLine($"{string.Join(", ",arr)}");
