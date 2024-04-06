namespace Solutions;

public class Solution18
{
    public void PrintSeconds(int n)
    {
        int second = n % 60;
        n /= 60;
        int minut = n % 60;
        Console.Write($"{(n / 60).ToString().PadLeft(2, '0')}:");
        Console.Write($"{minut.ToString().PadLeft(2, '0')}:");
        Console.Write($"{second.ToString().PadLeft(2, '0')}");
    }
}