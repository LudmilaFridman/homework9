System.Console.Write("enter m=");
uint m = uint.Parse(Console.ReadLine());
System.Console.Write("enter n=");
uint n = uint.Parse(Console.ReadLine());

static uint AckermanFunction(uint n, uint m)
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