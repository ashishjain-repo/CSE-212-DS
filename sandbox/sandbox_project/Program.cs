using System;
using System.Collections.Generic;

public class Program
{
    public static string OrderedNoSpace(string word)
    {
        string temp = "";
        foreach(char c in word.ToLower())
        {
            if(c.ToString() == " ")
            {
                continue;
            }
            temp+=c;
        }
        char[] character = temp.ToCharArray();
        for(int i = 0; i < character.Length - 1; i++)
        {
            for(int j = 0; j < character.Length - i - 1; j++)
            {
                if((int)character[j] > character[j + 1])
                {
                    char temporary = character[j];
                    character[j] = character[j + 1];
                    character[j + 1] = temporary;

                }
            }
        }
        string orderSorted = new string(character);
        return orderSorted;
    }
    public static bool IsAnagram(string word1, string word2)
    {
        // TODO Problem 3 - ADD YOUR CODE HERE
        string sorted1 = new string(OrderedNoSpace(word1));
        string sorted2 = new string(OrderedNoSpace(word2));
        Dictionary<string, string> words = new Dictionary<string, string>() 
        {
            {"word1",sorted1},
            {"word2",sorted2}
        };
        if(words["word1"] == words["word2"])
        {
            return true;
        }
        return false;
    }
    
    public static void Main(string[] args)
    {
        
        Console.WriteLine(IsAnagram("Eleven plus Two", "Twelve Plus One"));
    }
}