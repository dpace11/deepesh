

namespace ConsoleApp1;

public class DayOne
{
    /// <summary>
    /// Create a function that takes two numbers as arguments and returns their sum.
    /// </summary>
    /// <example>
    /// addition(3, 2) ➞ 5
    /// addition(-3, -6) ➞ -9
    /// </example>

    public void Sum(int firstnum, int secondnum)
    {
        var result = firstnum + secondnum;
        Console.WriteLine($"the sum of {firstnum} and {secondnum} is {result}");

    }
}