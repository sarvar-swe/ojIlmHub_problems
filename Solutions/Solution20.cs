namespace Solutions;

public class Solution20
{
    //Yandex taxi
    public void PrintRoundedNumber(int n)
    {
        int m = n % 1000;
        if((m / 100) >= 5)
        {
            Console.WriteLine(n - m + 1000);
        }
        else
        {
            Console.WriteLine(m - m);
        }
    }
}