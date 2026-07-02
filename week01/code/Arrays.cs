using System.Security.Cryptography.X509Certificates;

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
        // TODO Problem 1 Starto
        // Remember: Using comments in your promgram, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1 is to create an array with the required length.
        // step 2 is to use a loop to go through each position in the array.
        // step 3 is to calculate the multiple for that position.
        // step 4 is to store the value in the array
        // step 5 is to return the completed array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i +1);
        }

        return result;
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

        // step 1 is to create a temporary array that has the same size as the original list
        // step 2 is to loop through each element in the original list.
        // step 3 is to calculate the new position for each element after rotating to the right
        // step 4 is to store each element in its new position in the temporary array
        // step 5 is to loop through the temporary array
        // step 6 is to copy each value back into the original list.

        int[] result = new int[data.Count];
        for (int i = 0; i < data.Count; i++)
        {
            int newIndex = (i + amount) % data.Count;
            result[newIndex] = data[i];
        }
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = result[i];
        }
    }
}
