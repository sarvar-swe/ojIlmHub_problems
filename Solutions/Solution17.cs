using System.Text;

namespace Solutions;

public class Solution17
{
    public void PrintSample(string str)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"{str[0]}");

        for(int i = 1; i < str.Length; i++)
        {
            stringBuilder.Append($"!{str[i]}");
        }

        Console.WriteLine(stringBuilder);
    }
}