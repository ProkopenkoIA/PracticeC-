Console.Clear();

string str1, str2;
int i, len;

Console.Write("Введите число ");

str1 = Console.ReadLine();
str2 = "";

len = str1.Length-1;

for (i = len;i>=0; i--)
{
  str2 = str2 + str1[i];  
}

if (str1==str2)
{Console.WriteLine("Число является палиндромом");}
else
{Console.WriteLine("Число не является палиндромом");}
