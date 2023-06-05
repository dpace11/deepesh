

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
    /// <summary>
    /// function to change minutes to seconds
    /// </summary>
    ///<example>
    ///convert(5) ➞ 300
    ///convert(3) ➞ 180
    ///</example>
    public void ConvertToMin(int minutes)
    {
        var seconds = minutes * 60;
        Console.WriteLine($"{minutes} minutes converted into seconds is {seconds}");
    }

    public void NextNumber(int number)
    {
        var incnum = number + 1;
        Console.WriteLine($"the next number after {number} is :{incnum}");
     }

    
}