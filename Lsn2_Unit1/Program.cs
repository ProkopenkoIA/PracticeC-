Console.Clear();

int A = new Random().Next(100,1000), B;


Console.WriteLine("Значение А = "+Convert.ToString(A));

B = (A%100)/10;

Console.WriteLine("Вторая цифра = "+Convert.ToString(B));