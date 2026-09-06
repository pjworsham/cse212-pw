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

        // ************************************************************
        //       Plan of how to implement the multiplesOf function
        // ************************************************************
        // create an array that has a length of 5 which is the length given
        // use a loop to go through the array one by one
        // multiply the number by each length of the numbers starting with 1 and going until you have reached 5 since 5 is the length
        // each number needs to be stored in the array
        // return multiples once the array has completed

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
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

        // *********************************************************************************
        //                  Plan for solving a complicated problem using a list
        // **********************************************************************************
        // start with the list of numbers
        // find how many numbers need to move from the end to the front using "amount"
        // save those numbers so they are not lost
        // remove the saved numbers from their original positions
        // then insert the saved numbers at the beginning of the list

        int startIndex = data.Count - amount;
        var numbersToMove = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, numbersToMove);
    }
}
