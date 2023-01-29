Console.Clear();

int[] nums = new int[3];// объявим массив

int max;


Console.WriteLine("Введите значение 1");

nums[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение 2");

nums[1] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите значение 3");

nums[2] = Convert.ToInt32(Console.ReadLine());

max = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (max<nums[i])
    {   
        max = nums[i];
    }
}

Console.WriteLine(" Наибольшее число = "+ Convert.ToString(max));
