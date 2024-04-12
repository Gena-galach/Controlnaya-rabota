using System;

class Program
{
    static void Main()
    {
        string[] input = {"I" , "enjoy" , "learning" , "programming" , "and", "playing" , "games" , "5" , "46", "FD"};
        string[] shortStrings = FilterShortStrings(input);
        
        foreach (var e in shortStrings)
        {
            Console.WriteLine(e);
        }
    }

    static string[] FilterShortStrings(string[] input)
    {
        string[] result = new string[input.Length];
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[count++] = input[i];
            }
        }

        Array.Resize(ref result, count); // Эта строка должна идти ПОСЛЕ цикла, иначе она изменит размер массива в процессе его заполнения

        return result;
    }
}