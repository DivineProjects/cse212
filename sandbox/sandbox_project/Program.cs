using System;


public class Program
{
    static List<int> RotateListRight(List<int> data, int n)
    {
        // Edge case: if the list is empty, return an empty list.
        if (data.Count == 0)
        {
            return new List<int>();
        }

        // Normalize n if it's greater than the size of the list.
        n = n % data.Count;

        // Edge case: if n is 0, no rotation is needed, return the original list.
        if (n == 0 || data.Count == n)
        {
            return new List<int>(data);
        }

        // Step 1: Get the last 'n' elements of the list (these will be moved to the front).
        List<int> rightPart = data.GetRange(data.Count - n, n);

        // Step 2: Get the first part of the list (elements that will follow the right part).
        List<int> leftPart = data.GetRange(0, data.Count - n);

        // Step 3: Concatenate the two parts: right part + left part.
        List<int> rotatedList = new List<int>();
        rotatedList.AddRange(rightPart);
        rotatedList.AddRange(leftPart);
        // Step 4: Return the rotated list.
        return rotatedList;
    }
    // private static void RotateListRight(List<int> data, int amount)
    // {
    //     List<int> rotatedData = RotateListRight(data, amount);
    //     foreach (var item in rotatedData)
    //     {
    //         Console.Write(item + " ");
    //     }
    // }
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
        
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int n = 0;

        List<int> rotatedData = RotateListRight(data, n);
        foreach (var item in rotatedData)
        {
            Console.Write(item + " ");
        }
    }
}