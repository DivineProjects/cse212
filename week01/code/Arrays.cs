public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

         // Create an array multiples[] to store the multiples of numbers with the specified length.
        double[] multiples = new double[length];

        // Loop through the multiples[] array 
        // fill it with multiples of the given number.
        for (int i = 0; i < length; i++)
        {
            // For each index 'i', multiply the number by (i + 1) to get the multiple.
            // i + 1 ensures that the first multiple is the number itself.
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // if the list is empty, return an empty list.
        if (data.Count == 0)
        {
            return;
        }

        // if amount is greater than the size of the list wrapping around the index number back to zero
        amount = amount % data.Count;

        // if amount is 0, no rotation is needed, return the original list.
        if (amount == 0)
        {
            return;
        }

        // Slice or Get the last 'amount' elements of the list.
        List<int> lastList = data.GetRange(data.Count - amount, amount);

        // Slice or Get the first part of the list.
        List<int> firstList = data.GetRange(0, data.Count - amount);

        // Concatenate the two lists
        data.Clear();
        data.AddRange(lastList);
        data.AddRange(firstList);
    }
}
