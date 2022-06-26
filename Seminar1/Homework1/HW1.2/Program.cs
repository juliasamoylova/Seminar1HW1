
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberВ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberВ && numberA > numberC)
{
    Console.WriteLine("Максимальное число: " + numberA);
}
if (numberВ > numberA && numberВ > numberC)
{
    Console.WriteLine("Максимальное число: " + numberВ);
}
if (numberC > numberA && numberC > numberВ)
{
    Console.WriteLine("Максимальное число: " + numberC);
}
