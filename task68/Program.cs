int Ankerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ankerman(m - 1, 1);
    else 
        return Ankerman(m - 1, Ankerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите первый параметр M функции Анкермана: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй параметр N функции Анкермана: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ankerman(M, N));
