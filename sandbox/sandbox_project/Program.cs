using System;

public class Program
{
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        // TODO problem 1
        for(int index = 1; index < number; index++)
        {
            if(number % index == 0)
            {
                results.Add(index);
            };
        };
        return results;
    }
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        List<int> divisors = FindDivisors(79);
        Console.WriteLine(string.Join(", ", divisors));
    }
}