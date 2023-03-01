Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int b = number % 2;
if (b == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}