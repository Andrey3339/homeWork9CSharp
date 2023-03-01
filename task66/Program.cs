int SumNumbers(int m, int n)
{
    if (n == m)
        return m;
    return SumNumbers(m, n -1) + n;
}

Console.Clear();
Console.Write("Введите первое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число N: ");
int N = Convert.ToInt32(Console.ReadLine());
while(N < M)
{
    Console.WriteLine("Второе число N должно быть больше или равно M.");
    Console.Write("Введите второе число N: ");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(SumNumbers(M, N));