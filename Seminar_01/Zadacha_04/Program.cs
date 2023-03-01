Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int b = 2;

if (number > 1)
{
    while (b <= number)
    {
        Console.Write(b + " ");
        b = b + 2;
    }
}