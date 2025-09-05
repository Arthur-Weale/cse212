using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 

    ///<Created Method for testing>
    public static void Run()
    {
        var newArray = MultiplesOf(7, 5);
        Debug.WriteLine("<double>{" + string.Join(", ", newArray) + "}");
        //Console.WriteLine("<double>{"+ string.Join(", ", newArray) +"}");
        List<int> data = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(data, 5);
    }
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /// <My Thought Process>
        /// First i will initialize and store an empty array that will hold my 5 multiples.
        /// I will create a for loop that iterates length times.
        /// Inside the loop i will multiply the current count of the loop to out number to get the multiple.
        /// I will then append the results into an array created.
        /// </My Thought Process>

        var multiplesArray = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiplesArray[i] = number * (i + 1);
        }
        Debug.WriteLine("<double>{"+ string.Join(", ", multiplesArray) +"}");
        return multiplesArray; // replace this return statement with your own
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

        ///<My Thought Process>
        /// First i will create the list with integers.
        /// Then i will create an new empty list with empty slots .
        /// I will create a for loop which will iterate through the list.
        /// While it iterates i will take the current value of the current index and shift it by the amount and insert it into a new list.
        /// I will get the new index position using modulo.
        /// </My Thought Process>

        List<int> newList = new List<int>(new int[data.Count]);

        for (int i = 0; i < data.Count; i++)
        {
            int newIndex = (i + amount) % data.Count;
            newList[newIndex] = data[i];
        }
        Console.WriteLine("List<int>{" + string.Join(" , ", newList) + "}");
    }
}
