public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
/*
Plan for MultiplesOf

I read what needs to be done to get the desired results. To do that I created a starting point so the initial multiplication with the number 1 so the result will be itself. I created an array with the length of the multiples required. Created a for loop from 0 so the one less number of length because the first position starts with 0. Then I added the multiple in the array by multiplying with the initial multiple and on every iteration I increased that multiple by one. After the iteration was finished I returned that array.
*/
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double numVar = 1;
        double[] doublesArr = new double[length];
        for(int i = 0; i < length; i++)
        {
            doublesArr[i] = number * numVar;
            numVar++;
        };

        return doublesArr; // replace this return statement with your own
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
/* 
Plan for RotateListRight

To solve this problem, I created a variable that holds the total number of iterations which is the provided list subtracting the total number that needs to be moved. Then each iteration adds the first element to the temp list removes the first element from the original list, and leaves the original list with only the number of elements passed in the function as an amount. Then I created a for each loop on the temporary list, and added those removed elements back in the list, so this way the original list is edited instead of returning a new list.
*/
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        int length = data.Count - amount;
        List<int> tempData = new List<int>();
        for(int i = 0; i < length; i++)
        {
            tempData.Add(data[0]);
            data.RemoveAt(0);
        };
        foreach(int i in tempData)
        {
            data.Add(i);
        };
    }
}
