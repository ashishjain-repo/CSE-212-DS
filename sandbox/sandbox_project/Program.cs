using System;
using System.Collections.Generic;

public class Program
{
    public static string[] FindPairs(string[] words)
    {
        // TODO Problem 1 - ADD YOUR CODE HERE
        HashSet<string> pairs = new HashSet<string>();
        HashSet<string> wordsList = new HashSet<string>(words); // Convert array to List

        // Iterate through a copy of the list to avoid modifying it while iterating
        foreach (string word in new List<string>(wordsList))
        {
            
            char[] characters = word.ToCharArray();
            Array.Reverse(characters);
            string reversed = new string(characters);

            // Check if the reversed word exists in the list
            if(word == reversed)
            {
                continue;
            }
            if (wordsList.Contains(reversed))
            {
                pairs.Add($"{word} & {reversed}");
                wordsList.Remove(word);    // Remove the current word
                wordsList.Remove(reversed); // Remove the matched reversed word
            }
        }

        return pairs.ToArray();
    }
    public static void Main(string[] args)
    {
        string[] data = ["ab","aa","ba"];
        string[] pairs = FindPairs(data);
        foreach(string pair in pairs)
        {
            Console.WriteLine(pair);
        }
    }
}