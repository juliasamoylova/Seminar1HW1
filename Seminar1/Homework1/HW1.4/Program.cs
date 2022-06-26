
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (numberN % 2 == 0)
{
    while (result < numberN)
    {
        Console.WriteLine(result + 2);
        result = result + 2;
    }
}
else
{
    while (result < (numberN - 1))
    {
        Console.WriteLine(result + 2);
        result = result + 2;
    }
}