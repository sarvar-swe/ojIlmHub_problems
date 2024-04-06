using System.Text;

namespace Solutions;

public class Solution17
{
    public void PrintSample(string str)
    {
        StringBuilder stringBuilder = new StringBuilder();
        if(str.Length < 5)
        {
            int c = 5 - str.Length;
            while(c > 0)
            {
                stringBuilder.Append("0!");
                c--;
            }
        }
        stringBuilder.Append($"{str[0]}");

        for(int i = 1; i < str.Length; i++)
        {
            stringBuilder.Append($"!{str[i]}");
        }

        Console.WriteLine(stringBuilder);
    }
}