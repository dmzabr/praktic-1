Console.WriteLine("Введите первое число: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > max)
{
    Console.WriteLine("Большее число - " + number);
}

else 
{
    Console.WriteLine("Большее число - " + max);
}

