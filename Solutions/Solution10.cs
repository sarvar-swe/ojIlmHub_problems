namespace Solutions;

public class Solution10
{
    public void PrintTenFibonacci()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
    }

    private static int Fibonacci(int n)
    {
        if(n == 0)
            return 0;

        int f0 = 0, f1 = 1;
        int fn = 1;

        for(int i = 1; i < n; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }

        return fn;
    }
}