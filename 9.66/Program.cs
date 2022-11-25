System.Console.Write("enter m=");
int m = int.Parse(Console.ReadLine());
System.Console.Write("enter n=");
int n = int.Parse(Console.ReadLine());

int GetSumMN(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    else
    {
        return GetSumMN(m,n-1) + n;
    }
}

System.Console.Write($"result is {GetSumMN(m,n)}");