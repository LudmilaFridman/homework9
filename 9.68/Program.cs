System.Console.Write("enter m=");
int m = int.Parse(Console.ReadLine());
System.Console.Write("enter n=");
int n = int.Parse(Console.ReadLine());

int AckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return AckermanFunction(n - 1, 1);
        }
        else
        {
            return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
        }
    }
}

System.Console.Write($"result is {AckermanFunction(m,n)}");