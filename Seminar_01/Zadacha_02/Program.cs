Console.Write("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C:");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    if (A > C)
        Console.WriteLine(A);
    else
        Console.WriteLine(C);
}
if (B > C)
{
    if (B > C)
        Console.WriteLine(B);
    else
        Console.WriteLine(C);
}