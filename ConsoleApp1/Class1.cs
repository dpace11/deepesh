

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

    /// <summary>
    /// Create a function that takes a number as an argument, increments the number by +1 and returns the result
    /// </summary>
    /// <example>
    /// Addition(0) ➞ 1
    /// Addition(9) ➞ 10

    /// </example>
    public void NextNumber(int number)
    {
        var incnum = number + 1;
        Console.WriteLine($"the next number after {number} is :{incnum}");
    }


    public void PowerCircuitCalcu(int voltage, int current)
    {
        var power = voltage * current;
        Console.WriteLine($"the power of the ciruit from voltage:{voltage} & current:{current} is {power}");
    }

    /// <summary>
    /// Create a function that takes the age in years and returns the age in days.
    /// </summary>
    /// <example>
    /// CalcAge(65) ➞ 23725
    /// CalcAge(20) ➞ 7300
    /// </example>
    public void AgeToDays(int age)
    
    {
        var yearlength = 365;
        var days = age * yearlength;
        Console.WriteLine($"the days of your {age} age is {days}");
    }


    /// <summary>
    /// a function that takes the base and height of a triangle and return its area.
    /// </summary>
    /// <example>
    /// triArea(3, 2) ➞ 3
    /// triArea(7, 4) ➞ 14
    /// </example>
    public void triArea(float length, float breadth)
    {
        var area = (length * breadth) / 2;
        Console.WriteLine($"area of triangle of length:{length} & breadth{breadth} is {area}");
    }

    /// <summary>
    /// There is a single operator in C#, capable of providing the remainder of a division operation. 
    /// Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.
    /// </summary>
   
    public void Rem(int num1, int num2)
    {
        var result = num1 % num2;
        Console.WriteLine($"remainder of {num1} & {num2} is {result}");


    }
}