System.Console.Write("enter n: ");
int n = int.Parse(Console.ReadLine());

void getNumbers(int n)
{
    if (n == 1)
    {
        System.Console.WriteLine(n);
        return;
    }
    else
    {
        System.Console.WriteLine(n);
        getNumbers(n-1);
    }
}

getNumbers(n);