
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberВ = Convert.ToInt32(Console.ReadLine());

if (numberA > numberВ)
    {
        Console.WriteLine("Максимальное число: " + numberA);
Console.WriteLine("Минимальное число: " + numberВ);
    }
else
{
    Console.WriteLine("Максимальное число: " + numberВ);
Console.WriteLine("Минимальное число: " + numberA);
}
